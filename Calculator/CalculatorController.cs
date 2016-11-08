using PeterO.Calculator;

namespace Calculator {
    /// <summary>Abstract controller for a calculator program. It is
    /// initialized with an IWindowInfo, which abstracts the window
    /// functionality needed for the calculator and helps this controller
    /// be framework-independent.</summary>
  internal class CalculatorController {
    private readonly IWindowInfo iwi;
    private readonly CalculatorState state;
    private ProgramConfig config;

    public void InitializeConfig() {
   this.config = new ProgramConfig(nameof(config)).FormPosFromConfig(this.iwi);
    }

    public void SaveConfig() {
      if (this.config != null) {
        this.config.FormPosToConfig(this.iwi).Save();
      }
    }

    public void SquareRootButton() {
      if (!this.state.SquareRootButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void AddButton() {
      if (!this.state.AddButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void DotButton() {
      if (!this.state.DotButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void BackButton() {
      if (!this.state.BackButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void PlusMinusButton() {
      if (!this.state.PlusMinusButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void EqualsButton() {
      if (!this.state.EqualsButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void SubtractButton() {
      if (!this.state.SubtractButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void MultiplyButton() {
      if (!this.state.MultiplyButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void DivideButton() {
      if (!this.state.DivideButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void ClearButton() {
      this.state.Clear();
      this.iwi.SetTextBox(this.state.Text);
    }

    public void ClearEntryButton() {
      this.state.ClearEntry();
      this.iwi.SetTextBox(this.state.Text);
    }

    public void Digit(int digit) {
      if (!this.state.DigitButton(digit)) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public void PercentButton() {
      if (!this.state.PercentButton()) {
        this.iwi.ErrorSound();
      }
      this.iwi.SetTextBox(this.state.Text);
    }

    public CalculatorController(IWindowInfo iwi) {
      this.iwi = iwi;
      this.state = new CalculatorState(18);
      iwi.SetTextBox(this.state.Text);
    }

    public bool KeyPress(char keyChar) {
      var handled = true;
      switch (keyChar) {
        case '0':
          this.Digit(0);
          break;
        case '1':
          this.Digit(1);
          break;
        case '2':
          this.Digit(2);
          break;
        case '3':
          this.Digit(3);
          break;
        case '4':
          this.Digit(4);
          break;
        case '5':
          this.Digit(5);
          break;
        case '6':
          this.Digit(6);
          break;
        case '7':
          this.Digit(7);
          break;
        case '8':
          this.Digit(8);
          break;
        case '9':
          this.Digit(9);
          break;
        case '\b':
          if (!this.state.BackButton()) {
            this.iwi.ErrorSound();
          }
          break;
        case '\r':
          if (!this.state.EqualsButton()) {
            this.iwi.ErrorSound();
          }
          break;
        case '+':
          if (!this.state.AddButton()) {
            this.iwi.ErrorSound();
          }
          break;
        case '-':
          if (!this.state.SubtractButton()) {
            this.iwi.ErrorSound();
          }
          break;
        case '*':
          if (!this.state.MultiplyButton()) {
            this.iwi.ErrorSound();
          }
          break;
        case '/':
          if (!this.state.DivideButton()) {
            this.iwi.ErrorSound();
          }
          break;
        case '.':
          if (!this.state.DotButton()) {
            this.iwi.ErrorSound();
          }
          break;
        default: handled = false;
          break;
      }
      this.iwi.SetTextBox(this.state.Text);
      return handled;
    }
  }
}
