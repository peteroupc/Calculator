/*
Written by Peter O. in 2014.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.dreamhosters.com/articles/donate-now-2/
 */
using System;
using System.Media;
using System.Windows.Forms;

using PeterO.Calculator;

namespace Calculator {
  internal partial class MainForm : Form
  {
    private readonly CalculatorState state;
    private ProgramConfig config;

    private ProgramConfig InitializeConfig() {
      var config = new ProgramConfig("config");
      int x = config.GetInt32OrDefault("x", this.Left);
      int y = config.GetInt32OrDefault("y", this.Top);
      int width = config.GetInt32OrDefault("width", this.Width);
      int height = config.GetInt32OrDefault("height", this.Height);
      this.Left = Math.Max(0, x);
      this.Top = Math.Max(0, y);
      this.Width = Math.Max(0, width);
      this.Height = Math.Max(0, height);
      return config;
    }

    private void SaveConfig() {
      if (this.config != null) {
        this.config.SetObject("x", this.Left)
          .SetObject("y", this.Top)
          .SetObject("width", this.Width)
          .SetObject("height", this.Height)
          .Save();
      }
    }

    public MainForm() {
      this.InitializeComponent();
      this.state = new CalculatorState(18);
      this.text.Text = this.state.Text;
    }

    private void Error() {
      SystemSounds.Beep.Play();
    }

    private void Digit(int digit) {
      if (!this.state.DigitButton(digit)) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void MainFormLoad(object sender, EventArgs e) {
      this.text.Text = this.state.Text;
    }

    internal void Button1Click(object sender, MouseEventArgs e) {
      this.Digit(1);
    }

    internal void Button2Click(object sender, MouseEventArgs e) {
      this.Digit(2);
    }

    internal void Button5Click(object sender, MouseEventArgs e) {
      this.Digit(4);
    }

    internal void Button6Click(object sender, MouseEventArgs e) {
      this.Digit(5);
    }

    internal void Button7Click(object sender, MouseEventArgs e) {
      this.Digit(6);
    }

    internal void Button9Click(object sender, MouseEventArgs e) {
      this.Digit(7);
    }

    internal void Button10Click(object sender, MouseEventArgs e) {
      this.Digit(8);
    }

    internal void Button11Click(object sender, MouseEventArgs e) {
      this.Digit(9);
    }

    internal void Button13Click(object sender, MouseEventArgs e) {
      this.Digit(0);
    }

    internal void Button4Click(object sender, MouseEventArgs e) {
      if (!this.state.AddButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button14Click(object sender, MouseEventArgs e) {
      if (!this.state.EqualsButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button3Click(object sender, MouseEventArgs e) {
      this.Digit(3);
    }

    internal void Button21Click(object sender, MouseEventArgs e) {
      if (!this.state.PlusMinusButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button8Click(object sender, MouseEventArgs e) {
      if (!this.state.SubtractButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button12Click(object sender, MouseEventArgs e) {
      if (!this.state.MultiplyButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button16Click(object sender, MouseEventArgs e) {
      if (!this.state.DivideButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button20Click(object sender, MouseEventArgs e) {
      if (!this.state.DotButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button17Click(object sender, MouseEventArgs e) {
      this.state.Clear();
      this.text.Text = this.state.Text;
    }

    internal void MainFormKeyPress(
object sender,
KeyPressEventArgs e) {
      bool handled = true;
       switch (e.KeyChar) {
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
            this.Error();
          }
          break;
        case '\r':
          if (!this.state.EqualsButton()) {
            this.Error();
          }
          break;
        case '+':
          if (!this.state.AddButton()) {
            this.Error();
          }
          break;
        case '-':
          if (!this.state.SubtractButton()) {
            this.Error();
          }
          break;
        case '*':
          if (!this.state.MultiplyButton()) {
            this.Error();
          }
          break;
        case '/':
          if (!this.state.DivideButton()) {
            this.Error();
          }
          break;
        case '.':
          if (!this.state.DotButton()) {
            this.Error();
          }
          break;
          default: handled = false;
          break;
      }
      e.Handled |= handled;
      this.text.Text = this.state.Text;
    }

    internal void Button19Click(object sender, EventArgs e) {
      if (!this.state.SquareRootButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    internal void Button18Click(object sender, EventArgs e) {
      this.state.ClearEntry();
      this.text.Text = this.state.Text;
    }

    private void button15_Click(object sender, MouseEventArgs e) {
      if (!this.state.PercentButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    private void GeneralKeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        if (!this.state.EqualsButton()) {
          this.Error();
        }
        this.text.Text = this.state.Text;
        e.SuppressKeyPress = true;
      }
      if (e.KeyCode == Keys.Back) {
        if (!this.state.BackButton()) {
          this.Error();
        }
        this.text.Text = this.state.Text;
        e.SuppressKeyPress = true;
      }
      if (e.KeyCode == Keys.Delete) {
        this.state.ClearEntry();
        this.text.Text = this.state.Text;
        e.SuppressKeyPress = true;
      }
      if (e.KeyCode == Keys.Escape) {
        this.state.Clear();
        this.text.Text = this.state.Text;
        e.SuppressKeyPress = true;
      }
    }

    private void EnterBehavior(object sender, PreviewKeyDownEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        if (!this.state.EqualsButton()) {
          this.Error();
        }
        this.text.Text = this.state.Text;
      } else {
        e.IsInputKey = true;
      }
    }

    private void button19_Click(object sender, EventArgs e) {
      if (!this.state.SquareRootButton()) {
        this.Error();
      }
      this.text.Text = this.state.Text;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      this.SaveConfig();
    }

    private void MainForm_Load(object sender, EventArgs e) {
      // Initialize config here, rather than in the constructor;
      // the system may automatically move the window in between
      this.config = this.InitializeConfig();
    }
  }
}
