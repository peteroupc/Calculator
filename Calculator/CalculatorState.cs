/*
Written by Peter O. in 2014.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.com/d/
 */
using System;
using System.Text;
using PeterO;

namespace Calculator {
  internal sealed class CalculatorState
  {
    private enum Operation {
      Nothing,
      Add,
      Subtract,
      Multiply,
      Divide
    }

    private const int MaxDigits = 18;

    ExtendedDecimal operand1;
    ExtendedDecimal operand2;
    private readonly StringBuilder buffer;
    private string text;
    private bool equalsPressed;
    private static readonly PrecisionContext
      context = PrecisionContext.ForPrecisionAndRounding(MaxDigits, Rounding.Up)
      .WithSimplified(true);
    int currentOperand;
    Operation currentOperation;

    public CalculatorState() {
      buffer = new StringBuilder();
      ClearInternal();
    }

    private void ClearInternal() {
      operand1 = ExtendedDecimal.Zero;
      operand2 = ExtendedDecimal.Zero;
      buffer.Clear();
      text="0";
      equalsPressed=false;
      currentOperand = 0;
      currentOperation = Operation.Nothing;
    }

    public void Clear() {
      ClearInternal();
    }

    public void ClearEntry() {
      buffer.Clear();
      text="0";
    }

    /// <value></value>
    public string Text {
      get {
        return text;
      }
    }

    private void SetText(ExtendedDecimal dec){
      text=(dec.IsNaN()) ? "Error" : dec.ToString();
    }
    
    private bool IsError(string textValue){
      return textValue.Equals("Error");
    }

    private int DigitCount() {
      int count = 0;
      for (int i = 0;i<buffer.Length; ++i) {
        if (buffer[i]>= '0' && buffer[0]<= '9') {
          ++count;
        }
      }
      return count;
    }

    public bool DigitButton(int digit) {
      equalsPressed=false;
      if(IsError(text)){
        return false;
      }
      int count = DigitCount();
      if (digit!=0 && buffer.ToString().Equals("0")) {
        // Replace 0 with another digit
        buffer.Clear();
      }
      if (digit==0 && buffer.ToString().Equals("0")) {
        // Don't add another 0 if buffer is only 0
        text=buffer.ToString();
        return false;
      }
      if (count<MaxDigits) {
        buffer.Append((char)('0'+digit));
        text=buffer.ToString();
        return true;
      } else {
        return false;
      }
    }

    public bool DotButton() {
      equalsPressed=false;
      if(IsError(text)){
        return false;
      }
      if (buffer.Length == 0) {
        buffer.Append("0.");
        text=buffer.ToString();
        return true;
      } else if (!buffer.ToString().Contains(".")) {
        buffer.Append(".");
        text=buffer.ToString();
        return true;
      } else {
        return false;
      }
    }

    public bool PlusMinusButton() {
      equalsPressed=false;
      if(IsError(text)){
        return false;
      }
      if(buffer.Length==0 && text.Length>0 && !text.Equals("0")){
        buffer.Append(text);
      }
      if (buffer.Length==0 || buffer.ToString().Equals("0")) {
        // don't negate 0
        return true;
      } else if (buffer[0]=='-') {
        buffer.Remove(0,1);
        text=buffer.ToString();
        return true;
      } else {
        buffer.Insert(0,"-",1);
        text=buffer.ToString();
        return true;
      }
    }

    /// <returns>A Boolean object.</returns>
    public bool BackButton() {
      equalsPressed=false;
      if(IsError(text)){
        return false;
      }
      if (buffer.Length == 0) {
        buffer.Append("0");
        text=buffer.ToString();
        return true;
      } else {
        if (buffer.ToString().Equals("0")) {
          return false;
        }
        buffer.Remove(buffer.Length-1, 1);
        if(buffer.Length==0){
          // Change to 0 if all the text was
          // removed
          buffer.Append("0");
        }
        text=buffer.ToString();
        return true;
      }
    }

    private ExtendedDecimal DoOperation() {
      if (currentOperation == Operation.Add) {
        return operand1.Add(operand2, context);
      }
      if (currentOperation == Operation.Subtract) {
        return operand1.Subtract(operand2, context);
      }
      if (currentOperation == Operation.Multiply) {
        return operand1.Multiply(operand2, context);
      }
      if (currentOperation == Operation.Divide) {
        return operand1.Divide(operand2, context);
      }
      throw new NotSupportedException();
    }

    public bool EqualsButton() {
      if(IsError(text)){
        return false;
      }
      if(equalsPressed){
        if(currentOperation!=Operation.Nothing){
          // Repeat the previous operation with the
          // changed operand1 and the same operand2
          operand1 = DoOperation();
          SetText(operand1);
          return true;
        }
      }
      if (currentOperand == 1) {
        operand2 = ExtendedDecimal.FromString(text, context);
        buffer.Clear();
        operand1 = DoOperation();
        SetText(operand1);
        currentOperand = 0;
        equalsPressed=true;
      }
      return true;
    }

    public bool SquareRootButton() {
      equalsPressed=false;
      if(IsError(text)){
        return false;
      }
      ExtendedDecimal op=ExtendedDecimal.FromString(text, context);
      op=op.SquareRoot(context);
      if(currentOperand==0){
        operand1 = op;
      } else {
        operand2 = op;
      }
      SetText(operand1);
      buffer.Clear();
      return true;
    }

    private bool OperationButton(Operation op) {
      equalsPressed=false;
      if(IsError(text)){
        return false;
      }
      if (currentOperand == 0) {
        // Store first operand
        currentOperand = 1;
        operand1 = ExtendedDecimal.FromString(text, context);
        operand2 = operand1;
        buffer.Clear();
        currentOperation = op;
        return true;
      } else {
        if(buffer.Length==0){
          currentOperation = op;
          return true;
        }
        EqualsButton();
        currentOperand = 0;
        return OperationButton(op);
      }
    }

    public bool AddButton() {
      return OperationButton(Operation.Add);
    }

    public bool SubtractButton() {
      return OperationButton(Operation.Subtract);
    }

    public bool MultiplyButton() {
      return OperationButton(Operation.Multiply);
    }

    public bool DivideButton() {
      return OperationButton(Operation.Divide);
    }
  }
}
