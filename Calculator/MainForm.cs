/*
Written by Peter O. in 2014.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.com/d/
 */
using System;
using System.Windows.Forms;
using System.Media;

namespace Calculator {
  /// <summary>Description of MainForm.</summary>
  public partial class MainForm : Form
  {
    readonly CalculatorState state;

    public MainForm() {
      //
      // The InitializeComponent() call is required for Windows Forms designer
      // support.
      //
      InitializeComponent();
      state = new CalculatorState();
      text.Text = state.Text;
    }
    
    private void Error(){
        SystemSounds.Beep.Play();
      
    }
    
    private void Digit(int digit) {
      if (!state.DigitButton(digit)) {
        Error();
      }
      text.Text = state.Text;
    }

    void MainFormLoad(object sender, EventArgs e) {
      text.Text = state.Text;
    }
    void Button1Click(object sender, EventArgs e) {
      Digit(1);
    }
    void Button2Click(object sender, EventArgs e) {
      Digit(2);
    }
    void Button5Click(object sender, EventArgs e) {
      Digit(4);
    }
    void Button6Click(object sender, EventArgs e) {
      Digit(5);
    }
    void Button7Click(object sender, EventArgs e) {
      Digit(6);
    }
    void Button9Click(object sender, EventArgs e) {
      Digit(7);
    }
    void Button10Click(object sender, EventArgs e) {
      Digit(8);
    }
    void Button11Click(object sender, EventArgs e) {
      Digit(9);
    }
    void Button13Click(object sender, EventArgs e) {
      Digit(0);
    }
    void Button4Click(object sender, EventArgs e) {
      state.AddButton();
      text.Text = state.Text;
    }
    void Button14Click(object sender, EventArgs e) {
      state.EqualsButton();
      text.Text = state.Text;
    }
    void Button3Click(object sender, EventArgs e) {
      Digit(3);
    }
    void Button21Click(object sender, EventArgs e) {
      // not implemented yet
    }
    void Button8Click(object sender, EventArgs e) {
      state.SubtractButton();
      text.Text = state.Text;
    }
    void Button12Click(object sender, EventArgs e) {
      state.MultiplyButton();
      text.Text = state.Text;
    }
    void Button16Click(object sender, EventArgs e) {
      state.DivideButton();
      text.Text = state.Text;
    }
    void Button20Click(object sender, EventArgs e) {
      if (!state.DotButton()) {
        Error();
      }
      text.Text = state.Text;
    }
    void Button17Click(object sender, EventArgs e) {
      state.Clear();
      text.Text = state.Text;
    }
    void MainFormKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs
                          e) {
      bool handled = true;
      switch(e.KeyChar) {
        case '0':
          Digit(0);
          break;
        case '1':
          Digit(1);
          break;
        case '2':
          Digit(2);
          break;
        case '3':
          Digit(3);
          break;
        case '4':
          Digit(4);
          break;
        case '5':
          Digit(5);
          break;
        case '6':
          Digit(6);
          break;
        case '7':
          Digit(7);
          break;
        case '8':
          Digit(8);
          break;
        case '9':
          Digit(9);
          break;
        case '\b':
          if (!state.BackButton()) {
            SystemSounds.Beep.Play();
          }
          break;
        case '\r':
          state.EqualsButton();
          break;
        case '+':
          state.AddButton();
          break;
        case '-':
          state.SubtractButton();
          break;
        case '*':
          state.MultiplyButton();
          break;
        case '/':
          state.DivideButton();
          break;
        case '.':
          if (!state.DotButton()) {
            Error();
          }
          break;
          default: handled = false;
          break;
      }
      e.Handled|=handled;
      text.Text = state.Text;
    }
    void Button19Click(object sender, System.EventArgs e) {
      if(!state.SquareRootButton()){
        Error();
      }
      text.Text = state.Text;
    }
    void Button21Enter(object sender, System.EventArgs e) {
    }
  }
}
