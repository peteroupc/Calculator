/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;
using System.Text;
using PeterO.Numbers;

namespace PeterO.Calculator {
  internal sealed class CalculatorState {
    private enum Operation {
      Nothing,
      Add,
      Subtract,
      Multiply,
      Divide,
    }

    private readonly StringBuilder buffer;
    private readonly EContext context;

    private readonly int maxDigits;

    private EDecimal operand1;
    private EDecimal operand2;
    private static readonly EDecimal Percent =
      EDecimal.FromString("0.01");

    private string text;
    private bool equalsPressed;

    private int currentOperand;
    private Operation currentOperation;

    public CalculatorState(int maxDigits) {
      this.maxDigits = maxDigits;
      this.context = EContext
        .ForPrecisionAndRounding(maxDigits, ERounding.HalfUp)
        .WithSimplified(true);
      this.buffer = new StringBuilder();
      this.ClearInternal();
    }

    private void ClearInternal() {
      this.operand1 = EDecimal.Zero;
      this.operand2 = EDecimal.Zero;
      this.buffer.Clear();
      this.text = "0";
      this.equalsPressed = false;
      this.currentOperand = 0;
      this.currentOperation = Operation.Nothing;
    }

    public void Clear() {
      this.ClearInternal();
    }

    public void ClearEntry() {
      this.buffer.Clear();
      this.text = "0";
    }

    public string Text {
      get {
        return this.text;
      }
    }

    private void SetText(EDecimal dec) {
      this.text = dec.IsNaN() ? "Error" : dec.ToString();
    }

    private static bool IsError(string textValue) {
      return textValue.Equals("Error");
    }

    private int DigitCount() {
      var count = 0;
      for (int i = 0; i < this.buffer.Length; ++i) {
        if (this.buffer[i] >= '0' && this.buffer[0] <= '9') {
          ++count;
        }
      }
      return count;
    }

    public bool DigitButton(int digit) {
      if (this.equalsPressed) {
        this.equalsPressed = false;
        this.currentOperand = 0;
      }
      if (IsError(this.text)) {
        return false;
      }
      var count = this.DigitCount();
      if (digit != 0 && this.buffer.ToString().Equals("0")) {
        // Replace 0 with another digit
        this.buffer.Clear();
      }
      if (digit == 0 && this.buffer.ToString().Equals("0")) {
        // Don't add another 0 if buffer is only 0
        this.text = this.buffer.ToString();
        return false;
      }
      if (count < this.maxDigits) {
        this.buffer.Append((char)('0' + digit));
        this.text = this.buffer.ToString();
        return true;
      }
      return false;
    }

    public bool DotButton() {
      this.equalsPressed = false;
      if (IsError(this.text)) {
        return false;
      }
      if (this.buffer.Length == 0) {
        this.buffer.Append("0.");
        this.text = this.buffer.ToString();
        return true;
      }
      if (!this.buffer.ToString().Contains(".")) {
        this.buffer.Append(".");
        this.text = this.buffer.ToString();
        return true;
      }
      return false;
    }

    public bool PlusMinusButton() {
      this.equalsPressed = false;
      if (IsError(this.text)) {
        return false;
      }
      if (this.buffer.Length == 0 && this.text.Length > 0 &&
        !this.text.Equals("0")) {
        this.buffer.Append(this.text);
      }
      if (this.buffer.Length == 0 || this.buffer.ToString().Equals("0")) {
        // don't negate 0
        return true;
      }
      if (this.buffer[0] == '-') {
        this.buffer.Remove(0, 1);
        this.text = this.buffer.ToString();
        return true;
      }
      this.buffer.Insert(0, "-", 1);
      this.text = this.buffer.ToString();
      return true;
    }

    public bool BackButton() {
      this.equalsPressed = false;
      if (IsError(this.text)) {
        return false;
      }
      if (this.buffer.Length == 0) {
        this.buffer.Append("0");
        this.text = this.buffer.ToString();
        return true;
      }
      if (this.buffer.ToString().Equals("0")) {
        return false;
      }
      this.buffer.Remove(this.buffer.Length - 1, 1);
      if (this.buffer.Length == 0) {
        // Change to 0 if all the text was
        // removed
        this.buffer.Append("0");
      }
      this.text = this.buffer.ToString();
      return true;
    }

    private EDecimal DoOperation() {
      if (this.currentOperation == Operation.Add) {
        return this.operand1.Add(this.operand2, this.context);
      }
      if (this.currentOperation == Operation.Subtract) {
        return this.operand1.Subtract(this.operand2, this.context);
      }
      if (this.currentOperation == Operation.Multiply) {
        return this.operand1.Multiply(this.operand2, this.context);
      }
      if (this.currentOperation == Operation.Divide) {
        return this.operand1.Divide(this.operand2, this.context);
      }
      throw new NotSupportedException();
    }

    public bool EqualsButton() {
      if (IsError(this.text)) {
        return false;
      }
      if (this.equalsPressed) {
        if (this.currentOperation != Operation.Nothing) {
          // Repeat the previous operation with the
          // changed operand1 and the same operand2
          this.operand1 = this.DoOperation();
          this.SetText(this.operand1);
          return true;
        }
      }
      if (this.currentOperand == 1) {
        this.operand2 = EDecimal.FromString(this.text, this.context);
        this.buffer.Clear();
        this.operand1 = this.DoOperation();
        this.SetText(this.operand1);
        this.currentOperand = 0;
        this.equalsPressed = true;
      }
      return true;
    }

    public bool SquareRootButton() {
      this.equalsPressed = false;
      if (IsError(this.text)) {
        return false;
      }
      var op = EDecimal.FromString(this.text, this.context);
      op = op.Sqrt(this.context);
      if (this.currentOperand == 0) {
        this.operand1 = op;
      } else {
        this.operand2 = op;
      }
      this.SetText(this.operand1);
      this.buffer.Clear();
      return true;
    }

    public bool PercentButton() {
      this.equalsPressed = false;
      if (IsError(this.text)) {
        return false;
      }
      if (this.currentOperand == 0) {
        this.operand1 = EDecimal.FromString(this.text, this.context);
        this.operand1 = this.operand1.Multiply(Percent, this.context);
        this.SetText(this.operand1);
        this.buffer.Clear();
        if (!this.operand1.IsNaN()) {
          this.buffer.Append(this.buffer.ToString());
        }
      } else {
        this.operand2 = EDecimal.FromString(this.text, this.context);
        this.operand2 = this.operand2.Multiply(Percent, this.context);
        this.SetText(this.operand2);
        this.buffer.Clear();
      }
      return true;
    }

    private bool OperationButton(Operation op) {
      this.equalsPressed = false;
      if (IsError(this.text)) {
        return false;
      }
      if (this.currentOperand == 0) {
        // Store first operand
        this.currentOperand = 1;
        this.operand1 = EDecimal.FromString(this.text, this.context);
        this.operand2 = this.operand1;
        this.buffer.Clear();
        this.currentOperation = op;
        return true;
      }
      if (this.buffer.Length == 0) {
        this.currentOperation = op;
        return true;
      }
      this.EqualsButton();
      this.currentOperand = 0;
      return this.OperationButton(op);
    }

    public bool AddButton() {
      return this.OperationButton(Operation.Add);
    }

    public bool SubtractButton() {
      return this.OperationButton(Operation.Subtract);
    }

    public bool MultiplyButton() {
      return this.OperationButton(Operation.Multiply);
    }

    public bool DivideButton() {
      return this.OperationButton(Operation.Divide);
    }
  }
}
