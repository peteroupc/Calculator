/*
Written by Peter O. in 2014.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.com/d/
 */
namespace Calculator {
  partial class MainForm
  {
    /// <summary>Designer variable used to keep track of non-visual
    /// components.</summary>
    private System.ComponentModel.IContainer components;

    /// <summary>Disposes resources used by the form.</summary>
    /// <param name='disposing'>True if managed resources should be disposed;
    /// otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    /// <summary>This method is required for Windows Forms designer support. Do not
    /// change the method contents inside the source code editor. The Forms designer
    /// might not be able to load this method if it was changed manually.</summary>
    private void InitializeComponent() {
      this.text = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      this.button11 = new System.Windows.Forms.Button();
      this.button12 = new System.Windows.Forms.Button();
      this.button13 = new System.Windows.Forms.Button();
      this.button14 = new System.Windows.Forms.Button();
      this.button16 = new System.Windows.Forms.Button();
      this.button15 = new System.Windows.Forms.Button();
      this.button17 = new System.Windows.Forms.Button();
      this.button18 = new System.Windows.Forms.Button();
      this.button19 = new System.Windows.Forms.Button();
      this.button20 = new System.Windows.Forms.Button();
      this.button21 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      //
      // text
      //
      this.text.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.text.CausesValidation = false;
      this.text.Font = new System.Drawing.Font("Calibri Light" , 18F,
        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
        ((byte)(0)));
      this.text.HideSelection = false;
      this.text.Location = new System.Drawing.Point(12, 12);
      this.text.Name = "text";
      this.text.ReadOnly = true;
      this.text.Size = new System.Drawing.Size(258, 37);
      this.text.TabIndex = 0;
      this.text.TabStop = false;
      this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.text.Enter += new System.EventHandler(this.Button21Enter);
      //
      // button1
      //
      this.button1.Location = new System.Drawing.Point(13, 167);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(60, 32);
      this.button1.TabIndex = 1;
      this.button1.TabStop = false;
      this.button1.Text = "1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1Click);
      this.button1.Enter += new System.EventHandler(this.Button21Enter);
      this.button1.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button4
      //
      this.button4.Location = new System.Drawing.Point(210, 129);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(60, 32);
      this.button4.TabIndex = 5;
      this.button4.TabStop = false;
      this.button4.Text = "+";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.Button4Click);
      this.button4.Enter += new System.EventHandler(this.Button21Enter);
      this.button4.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button2
      //
      this.button2.Location = new System.Drawing.Point(79, 167);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(60, 32);
      this.button2.TabIndex = 6;
      this.button2.TabStop = false;
      this.button2.Text = "2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2Click);
      this.button2.Enter += new System.EventHandler(this.Button21Enter);
      this.button2.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button3
      //
      this.button3.Location = new System.Drawing.Point(144, 167);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(60, 32);
      this.button3.TabIndex = 7;
      this.button3.TabStop = false;
      this.button3.Text = "3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.Button3Click);
      this.button3.Enter += new System.EventHandler(this.Button21Enter);
      this.button3.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button5
      //
      this.button5.Location = new System.Drawing.Point(13, 129);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(60, 32);
      this.button5.TabIndex = 8;
      this.button5.TabStop = false;
      this.button5.Text = "4";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.Button5Click);
      this.button5.Enter += new System.EventHandler(this.Button21Enter);
      this.button5.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button6
      //
      this.button6.Location = new System.Drawing.Point(79, 129);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(60, 32);
      this.button6.TabIndex = 9;
      this.button6.TabStop = false;
      this.button6.Text = "5";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.Button6Click);
      this.button6.Enter += new System.EventHandler(this.Button21Enter);
      this.button6.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button7
      //
      this.button7.Location = new System.Drawing.Point(145, 129);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(60, 32);
      this.button7.TabIndex = 10;
      this.button7.TabStop = false;
      this.button7.Text = "6";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.Button7Click);
      this.button7.Enter += new System.EventHandler(this.Button21Enter);
      this.button7.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button8
      //
      this.button8.Location = new System.Drawing.Point(210, 167);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(60, 32);
      this.button8.TabIndex = 11;
      this.button8.TabStop = false;
      this.button8.Text = "-";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.Button8Click);
      this.button8.Enter += new System.EventHandler(this.Button21Enter);
      this.button8.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button9
      //
      this.button9.Location = new System.Drawing.Point(13, 91);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(60, 32);
      this.button9.TabIndex = 12;
      this.button9.TabStop = false;
      this.button9.Text = "7";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.Button9Click);
      this.button9.Enter += new System.EventHandler(this.Button21Enter);
      this.button9.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button10
      //
      this.button10.Location = new System.Drawing.Point(79, 91);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(60, 32);
      this.button10.TabIndex = 13;
      this.button10.TabStop = false;
      this.button10.Text = "8";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new System.EventHandler(this.Button10Click);
      this.button10.Enter += new System.EventHandler(this.Button21Enter);
      this.button10.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button11
      //
      this.button11.Location = new System.Drawing.Point(144, 91);
      this.button11.Name = "button11";
      this.button11.Size = new System.Drawing.Size(60, 32);
      this.button11.TabIndex = 14;
      this.button11.TabStop = false;
      this.button11.Text = "9";
      this.button11.UseVisualStyleBackColor = true;
      this.button11.Click += new System.EventHandler(this.Button11Click);
      this.button11.Enter += new System.EventHandler(this.Button21Enter);
      this.button11.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button12
      //
      this.button12.Location = new System.Drawing.Point(210, 205);
      this.button12.Name = "button12";
      this.button12.Size = new System.Drawing.Size(60, 32);
      this.button12.TabIndex = 15;
      this.button12.TabStop = false;
      this.button12.Text = "×";
      this.button12.UseVisualStyleBackColor = true;
      this.button12.Click += new System.EventHandler(this.Button12Click);
      this.button12.Enter += new System.EventHandler(this.Button21Enter);
      this.button12.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button13
      //
      this.button13.Location = new System.Drawing.Point(79, 205);
      this.button13.Name = "button13";
      this.button13.Size = new System.Drawing.Size(126, 32);
      this.button13.TabIndex = 16;
      this.button13.TabStop = false;
      this.button13.Text = "0";
      this.button13.UseVisualStyleBackColor = true;
      this.button13.Click += new System.EventHandler(this.Button13Click);
      this.button13.Enter += new System.EventHandler(this.Button21Enter);
      this.button13.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button14
      //
      this.button14.Location = new System.Drawing.Point(144, 243);
      this.button14.Name = "button14";
      this.button14.Size = new System.Drawing.Size(126, 32);
      this.button14.TabIndex = 17;
      this.button14.TabStop = false;
      this.button14.Text = "=";
      this.button14.UseVisualStyleBackColor = true;
      this.button14.Click += new System.EventHandler(this.Button14Click);
      this.button14.Enter += new System.EventHandler(this.Button21Enter);
      this.button14.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button16
      //
      this.button16.Location = new System.Drawing.Point(79, 243);
      this.button16.Name = "button16";
      this.button16.Size = new System.Drawing.Size(60, 32);
      this.button16.TabIndex = 19;
      this.button16.TabStop = false;
      this.button16.Text = "÷";
      this.button16.UseVisualStyleBackColor = true;
      this.button16.Click += new System.EventHandler(this.Button16Click);
      this.button16.Enter += new System.EventHandler(this.Button21Enter);
      this.button16.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button15
      //
      this.button15.Location = new System.Drawing.Point(210, 55);
      this.button15.Name = "button15";
      this.button15.Size = new System.Drawing.Size(60, 32);
      this.button15.TabIndex = 20;
      this.button15.TabStop = false;
      this.button15.Text = "%";
      this.button15.UseVisualStyleBackColor = true;
      this.button15.Enter += new System.EventHandler(this.Button21Enter);
      this.button15.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button17
      //
      this.button17.Location = new System.Drawing.Point(13, 55);
      this.button17.Name = "button17";
      this.button17.Size = new System.Drawing.Size(95, 32);
      this.button17.TabIndex = 0;
      this.button17.TabStop = false;
      this.button17.Text = "C";
      this.button17.UseVisualStyleBackColor = true;
      this.button17.Click += new System.EventHandler(this.Button17Click);
      this.button17.Enter += new System.EventHandler(this.Button21Enter);
      this.button17.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button18
      //
      this.button18.Location = new System.Drawing.Point(114, 55);
      this.button18.Name = "button18";
      this.button18.Size = new System.Drawing.Size(90, 32);
      this.button18.TabIndex = 0;
      this.button18.TabStop = false;
      this.button18.Text = "CE";
      this.button18.UseVisualStyleBackColor = true;
      this.button18.Enter += new System.EventHandler(this.Button21Enter);
      this.button18.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button19
      //
      this.button19.Location = new System.Drawing.Point(210, 91);
      this.button19.Name = "button19";
      this.button19.Size = new System.Drawing.Size(60, 32);
      this.button19.TabIndex = 23;
      this.button19.TabStop = false;
      this.button19.Text = "√";
      this.button19.UseVisualStyleBackColor = true;
      this.button19.Click += new System.EventHandler(this.Button19Click);
      this.button19.Enter += new System.EventHandler(this.Button21Enter);
      this.button19.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button20
      //
      this.button20.Location = new System.Drawing.Point(13, 205);
      this.button20.Name = "button20";
      this.button20.Size = new System.Drawing.Size(60, 32);
      this.button20.TabIndex = 24;
      this.button20.TabStop = false;
      this.button20.Text = ".";
      this.button20.UseVisualStyleBackColor = true;
      this.button20.Click += new System.EventHandler(this.Button20Click);
      this.button20.Enter += new System.EventHandler(this.Button21Enter);
      this.button20.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // button21
      //
      this.button21.Location = new System.Drawing.Point(12, 243);
      this.button21.Name = "button21";
      this.button21.Size = new System.Drawing.Size(60, 32);
      this.button21.TabIndex = 25;
      this.button21.TabStop = false;
      this.button21.Text = "±";
      this.button21.UseVisualStyleBackColor = true;
      this.button21.Enter += new System.EventHandler(this.Button21Enter);
      this.button21.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      //
      // MainForm
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 282);
      this.Controls.Add(this.button21);
      this.Controls.Add(this.button20);
      this.Controls.Add(this.button19);
      this.Controls.Add(this.button18);
      this.Controls.Add(this.button17);
      this.Controls.Add(this.button15);
      this.Controls.Add(this.button16);
      this.Controls.Add(this.button14);
      this.Controls.Add(this.button13);
      this.Controls.Add(this.button12);
      this.Controls.Add(this.button11);
      this.Controls.Add(this.button10);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.text);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Calculator";
      this.KeyPress += new
        System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
    private System.Windows.Forms.Button button21;
    private System.Windows.Forms.Button button20;
    private System.Windows.Forms.TextBox text;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button11;
    private System.Windows.Forms.Button button12;
    private System.Windows.Forms.Button button13;
    private System.Windows.Forms.Button button14;
    private System.Windows.Forms.Button button16;
    private System.Windows.Forms.Button button15;
    private System.Windows.Forms.Button button17;
    private System.Windows.Forms.Button button18;
    private System.Windows.Forms.Button button19;
  }
}
