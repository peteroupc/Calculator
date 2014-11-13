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
    /// <summary>Description of CalculatorState.</summary>
  public sealed class CalculatorState
  {
    private enum Operation {
      Nothing,
      Add,
      Subtract,
      Multiply,
      Divide
    }

    private const int MaxDigits = 12;

    ExtendedDecimal operand1;
    ExtendedDecimal operand2;
    private readonly StringBuilder buffer;
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
      buffer.Append("0");
      currentOperand = 0;
      currentOperation = Operation.Nothing;
    }

/// </summary>
/// <returns></returns>
public void Clear() {
      ClearInternal();
    }

/// </summary>
public string Text {
      get {
        if (buffer.Length > 0) {
          // Buffer is being filled
          return buffer.ToString();
        }
        return (currentOperand == 0) ? ((operand1.IsNaN()) ? "Error" :
          operand1.ToString()) : ((operand2.IsNaN()) ? "Error" :
          operand2.ToString());
      }
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

/// </summary>
/// <param name="digit"></param>
/// <returns></returns>
public void DigitButton(int digit) {
      int count = DigitCount();
      if (digit!=0 && buffer.ToString().Equals("0")) {
        // Replace 0 with another digit
        buffer.Clear();
      }
      if (digit==0 && buffer.ToString().Equals("0")) {
        // Don't add another 0 if buffer is only 0
        return;
      }
      if (count<MaxDigits) {
        buffer.Append((char)('0'+digit));
      }
    }

/// </summary>
/// <returns></returns>
public void DotButton() {
      if (buffer.Length == 0) {
        buffer.Append("0.");
      } else if (!buffer.ToString().Contains(".")) {
        buffer.Append(".");
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

/// </summary>
/// <returns></returns>
public void EqualsButton() {
      if (currentOperand == 1) {
        if (buffer.Length == 0) {
          // Use previous operand
          operand2 = operand1;
        } else {
          operand2 = ExtendedDecimal.FromString(buffer.ToString(), context);
        }
        buffer.Clear();
        operand1 = DoOperation();
        operand2 = operand1;
        currentOperand = 0;
        currentOperation = Operation.Nothing;
      }
    }

    private void OperationButton(Operation op) {
      if (currentOperand == 0) {
        // Store first operand
        currentOperand = 1;
        operand1 = ExtendedDecimal.FromString(buffer.ToString(), context);
        operand2 = operand1;
        buffer.Clear();
        currentOperation = op;
      } else {
        // Already have first operand
        if (buffer.Length == 0) {
          // Use previous operand
          operand2 = operand1;
        } else {
          operand2 = ExtendedDecimal.FromString(buffer.ToString(), context);
        }
        buffer.Clear();
        operand1 = DoOperation();
        operand2 = operand1;
        currentOperation = op;
      }
    }

/// </summary>
/// <returns></returns>
public void AddButton() {
      OperationButton(Operation.Add);
    }

/// </summary>
/// <returns></returns>
public void SubtractButton() {
      OperationButton(Operation.Subtract);
    }

/// </summary>
/// <returns></returns>
public void MultiplyButton() {
      OperationButton(Operation.Multiply);
    }

/// </summary>
/// <returns></returns>
public void DivideButton() {
      OperationButton(Operation.Divide);
    }
  }
}
