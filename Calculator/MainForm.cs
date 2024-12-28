/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
using System;
using System.Windows.Forms;

namespace Calculator {
  internal partial class MainForm : Form {
    private readonly CalculatorController cc;

    public MainForm() {
      this.InitializeComponent();
      this.cc = new CalculatorController(new FormWindowInfo(this));
    }

    internal void Button1Click(object sender, MouseEventArgs e) {
      this.cc.Digit(1);
    }

    internal void Button2Click(object sender, MouseEventArgs e) {
      this.cc.Digit(2);
    }

    internal void Button5Click(object sender, MouseEventArgs e) {
      this.cc.Digit(4);
    }

    internal void Button6Click(object sender, MouseEventArgs e) {
      this.cc.Digit(5);
    }

    internal void Button7Click(object sender, MouseEventArgs e) {
      this.cc.Digit(6);
    }

    internal void Button9Click(object sender, MouseEventArgs e) {
      this.cc.Digit(7);
    }

    internal void Button10Click(object sender, MouseEventArgs e) {
      this.cc.Digit(8);
    }

    internal void Button11Click(object sender, MouseEventArgs e) {
      this.cc.Digit(9);
    }

    internal void Button13Click(object sender, MouseEventArgs e) {
      this.cc.Digit(0);
    }

    internal void Button4Click(object sender, MouseEventArgs e) {
      this.cc.AddButton();
    }

    internal void Button14Click(object sender, MouseEventArgs e) {
      this.cc.EqualsButton();
    }

    internal void Button3Click(object sender, MouseEventArgs e) {
      this.cc.Digit(3);
    }

    internal void Button21Click(object sender, MouseEventArgs e) {
      this.cc.PlusMinusButton();
    }

    internal void Button8Click(object sender, MouseEventArgs e) {
      this.cc.SubtractButton();
    }

    internal void Button12Click(object sender, MouseEventArgs e) {
      this.cc.MultiplyButton();
    }
    internal void Button12_Click(object sender, EventArgs e) {
      this.Button12Click(sender, (MouseEventArgs)e);
    }

    internal void Button16Click(object sender, MouseEventArgs e) {
      this.cc.DivideButton();
    }

    internal void Button20Click(object sender, MouseEventArgs e) {
      this.cc.DotButton();
    }

    internal void Button17Click(object sender, MouseEventArgs e) {
      this.cc.ClearButton();
    }

    internal void MainFormKeyPress(
      object sender,
      KeyPressEventArgs e) {
      e.Handled |= this.cc.KeyPress(e.KeyChar);
    }
    internal void Button19Click(object sender, EventArgs e) {
      this.cc.SquareRootButton();
    }

    internal void Button19_Click(object sender, EventArgs e) {
      this.cc.SquareRootButton();
    }

    internal void Button18Click(object sender, EventArgs e) {
      this.cc.ClearEntryButton();
    }

    private void Button15_Click(object sender, MouseEventArgs e) {
      this.cc.PercentButton();
    }

    private void GeneralKeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        this.cc.EqualsButton();
        e.SuppressKeyPress = true;
      }
      if (e.KeyCode == Keys.Back) {
        this.cc.BackButton();
        e.SuppressKeyPress = true;
      }
      if (e.KeyCode == Keys.Delete) {
        this.cc.ClearEntryButton();
        e.SuppressKeyPress = true;
      }
      if (e.KeyCode == Keys.Escape) {
        this.cc.ClearButton();
        e.SuppressKeyPress = true;
      }
    }

    private void EnterBehavior(object sender, PreviewKeyDownEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        this.cc.EqualsButton();
      } else {
        e.IsInputKey = true;
      }
    }

    private void Button19_Click(object sender, EventArgs e) {
      this.cc.SquareRootButton();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      this.cc.SaveConfig();
    }

    private void MainForm_Load(object sender, EventArgs e) {
      // Initialize config here, rather than in the constructor;
      // the system may automatically move the window in between
      this.cc.InitializeConfig();
    }

    private void Button12_Click(object sender, EventArgs e) {
      this.cc.MultiplyButton();
    }
  }
}
