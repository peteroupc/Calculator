/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under the Unlicense: https://unlicense.org/

 */
namespace Calculator {
  internal partial class MainForm {
    /// <summary>Designer variable used to keep track of nonvisual
    /// components.</summary>
    private System.ComponentModel.IContainer components;

    /// <summary>Disposes resources used by the form.</summary>
    /// <param name='disposing'>True if managed resources should be
    /// disposed; otherwise, false.</param>
    protected override void Dispose (bool disposing) {
      if (disposing) {
        if (this.components != null) {
          this.components.Dispose();
        }
      }
      base.Dispose (disposing);
    }

    /// <summary>This method is required for Windows Forms designer
    /// support. Do not change the method contents inside the source code
    /// editor. The Forms designer might not be able to load this method if
    /// it was changed manually.</summary>
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

      // text
      this.text.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.text.CausesValidation = false;
      this.text.Font = new System.Drawing.Font(
        "Calibri Light",
        15.75F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.text.HideSelection = false;
      this.text.Location = new System.Drawing.Point(12, 12);
      this.text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.text.Name = "text";
      this.text.ReadOnly = true;
      this.text.Size = new System.Drawing.Size(258, 33);
      this.text.TabIndex = 0;
      this.text.TabStop = false;
      this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.text.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.text.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button1
      this.button1.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button1.Location = new System.Drawing.Point(13, 167);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(60, 32);
      this.button1.TabIndex = 1;
      this.button1.TabStop = false;
      this.button1.Text = "1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button1.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button1.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button1Click);
      this.button1.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button4
      this.button4.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button4.Location = new System.Drawing.Point(210, 91);
      this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(60, 32);
      this.button4.TabIndex = 5;
      this.button4.TabStop = false;
      this.button4.Text = "+";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button4.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button4.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button4Click);
      this.button4.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button2
      this.button2.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button2.Location = new System.Drawing.Point(79, 167);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(60, 32);
      this.button2.TabIndex = 6;
      this.button2.TabStop = false;
      this.button2.Text = "2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button2.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button2.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button2Click);
      this.button2.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button3
      this.button3.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button3.Location = new System.Drawing.Point(144, 167);
      this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(60, 32);
      this.button3.TabIndex = 7;
      this.button3.TabStop = false;
      this.button3.Text = "3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button3.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button3.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button3Click);
      this.button3.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button5
      this.button5.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button5.Location = new System.Drawing.Point(13, 129);
      this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(60, 32);
      this.button5.TabIndex = 8;
      this.button5.TabStop = false;
      this.button5.Text = "4";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button5.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button5.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button5Click);
      this.button5.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button6
      this.button6.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button6.Location = new System.Drawing.Point(79, 129);
      this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(60, 32);
      this.button6.TabIndex = 9;
      this.button6.TabStop = false;
      this.button6.Text = "5";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button6.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button6.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button6Click);
      this.button6.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button7
      this.button7.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button7.Location = new System.Drawing.Point(145, 129);
      this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(60, 32);
      this.button7.TabIndex = 10;
      this.button7.TabStop = false;
      this.button7.Text = "6";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button7.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button7.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button7Click);
      this.button7.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button8
      this.button8.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button8.Location = new System.Drawing.Point(210, 129);
      this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(60, 32);
      this.button8.TabIndex = 11;
      this.button8.TabStop = false;
      this.button8.Text = "-";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button8.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button8.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button8Click);
      this.button8.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button9
      this.button9.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button9.Location = new System.Drawing.Point(13, 91);
      this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(60, 32);
      this.button9.TabIndex = 12;
      this.button9.TabStop = false;
      this.button9.Text = "7";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button9.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button9.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button9Click);
      this.button9.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button10
      this.button10.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button10.Location = new System.Drawing.Point(79, 91);
      this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(60, 32);
      this.button10.TabIndex = 13;
      this.button10.TabStop = false;
      this.button10.Text = "8";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button10.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button10.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button10Click);
      this.button10.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button11
      this.button11.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button11.Location = new System.Drawing.Point(144, 91);
      this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button11.Name = "button11";
      this.button11.Size = new System.Drawing.Size(60, 32);
      this.button11.TabIndex = 14;
      this.button11.TabStop = false;
      this.button11.Text = "9";
      this.button11.UseVisualStyleBackColor = true;
      this.button11.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button11.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button11.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button11Click);
      this.button11.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button12
      this.button12.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button12.Location = new System.Drawing.Point(210, 167);
      this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button12.Name = "button12";
      this.button12.Size = new System.Drawing.Size(60, 32);
      this.button12.TabIndex = 15;
      this.button12.TabStop = false;
      this.button12.Text = "×";
      this.button12.UseVisualStyleBackColor = true;
      this.button12.Click += new System.EventHandler(this.button12_Click);
      this.button12.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button12.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button12.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button12Click);
      this.button12.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button13
      this.button13.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button13.Location = new System.Drawing.Point(79, 204);
      this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button13.Name = "button13";
      this.button13.Size = new System.Drawing.Size(126, 32);
      this.button13.TabIndex = 16;
      this.button13.TabStop = false;
      this.button13.Text = "0";
      this.button13.UseVisualStyleBackColor = true;
      this.button13.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button13.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button13.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button13Click);
      this.button13.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button14
      this.button14.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button14.Location = new System.Drawing.Point(79, 243);
      this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button14.Name = "button14";
      this.button14.Size = new System.Drawing.Size(191, 32);
      this.button14.TabIndex = 17;
      this.button14.TabStop = false;
      this.button14.Text = "=";
      this.button14.UseVisualStyleBackColor = true;
      this.button14.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button14.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button14.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button14Click);
      this.button14.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button16
      this.button16.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button16.Location = new System.Drawing.Point(210, 204);
      this.button16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button16.Name = "button16";
      this.button16.Size = new System.Drawing.Size(60, 32);
      this.button16.TabIndex = 19;
      this.button16.TabStop = false;
      this.button16.Text = "÷";
      this.button16.UseVisualStyleBackColor = true;
      this.button16.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button16.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button16.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button16Click);
      this.button16.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button15
      this.button15.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button15.Location = new System.Drawing.Point(145, 56);
      this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button15.Name = "button15";
      this.button15.Size = new System.Drawing.Size(60, 32);
      this.button15.TabIndex = 20;
      this.button15.TabStop = false;
      this.button15.Text = "%";
      this.button15.UseVisualStyleBackColor = true;
      this.button15.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button15.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button15.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.button15_Click);
      this.button15.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button17
      this.button17.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button17.Location = new System.Drawing.Point(13, 56);
      this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button17.Name = "button17";
      this.button17.Size = new System.Drawing.Size(60, 32);
      this.button17.TabIndex = 0;
      this.button17.TabStop = false;
      this.button17.Text = "C";
      this.button17.UseVisualStyleBackColor = true;
      this.button17.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button17.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button17.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button17Click);
      this.button17.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button18
      this.button18.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button18.Location = new System.Drawing.Point(79, 56);
      this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button18.Name = "button18";
      this.button18.Size = new System.Drawing.Size(60, 32);
      this.button18.TabIndex = 0;
      this.button18.TabStop = false;
      this.button18.Text = "CE";
      this.button18.UseVisualStyleBackColor = true;
      this.button18.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button18.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button18.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button18Click);
      this.button18.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button19
      this.button19.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button19.Location = new System.Drawing.Point(211, 56);
      this.button19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button19.Name = "button19";
      this.button19.Size = new System.Drawing.Size(60, 32);
      this.button19.TabIndex = 23;
      this.button19.TabStop = false;
      this.button19.Text = "√";
      this.button19.UseVisualStyleBackColor = true;
      this.button19.Click += new System.EventHandler(this.button19_Click);
      this.button19.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button19.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button19.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button19Click);
      this.button19.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button20
      this.button20.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button20.Location = new System.Drawing.Point(13, 204);
      this.button20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button20.Name = "button20";
      this.button20.Size = new System.Drawing.Size(60, 32);
      this.button20.TabIndex = 24;
      this.button20.TabStop = false;
      this.button20.Text = ".";
      this.button20.UseVisualStyleBackColor = true;
      this.button20.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button20.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button20.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button20Click);
      this.button20.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // button21
      this.button21.Font = new System.Drawing.Font(
        "Arial",
        12F,
        System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point,
        (byte)0);
      this.button21.Location = new System.Drawing.Point(12, 243);
      this.button21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.button21.Name = "button21";
      this.button21.Size = new System.Drawing.Size(60, 32);
      this.button21.TabIndex = 25;
      this.button21.TabStop = false;
      this.button21.Text = "±";
      this.button21.UseVisualStyleBackColor = true;
      this.button21.KeyDown += new
System.Windows.Forms.KeyEventHandler(this.GeneralKeyDown);
      this.button21.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.button21.MouseClick += new
System.Windows.Forms.MouseEventHandler(this.Button21Click);
      this.button21.PreviewKeyDown += new
System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterBehavior);

      // MainForm
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 282);
      this.Controls.Add (this.button21);
      this.Controls.Add (this.button20);
      this.Controls.Add (this.button19);
      this.Controls.Add (this.button18);
      this.Controls.Add (this.button17);
      this.Controls.Add (this.button15);
      this.Controls.Add (this.button16);
      this.Controls.Add (this.button14);
      this.Controls.Add (this.button13);
      this.Controls.Add (this.button12);
      this.Controls.Add (this.button11);
      this.Controls.Add (this.button10);
      this.Controls.Add (this.button9);
      this.Controls.Add (this.button8);
      this.Controls.Add (this.button7);
      this.Controls.Add (this.button6);
      this.Controls.Add (this.button5);
      this.Controls.Add (this.button3);
      this.Controls.Add (this.button2);
      this.Controls.Add (this.button4);
      this.Controls.Add (this.button1);
      this.Controls.Add (this.text);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Calculator";
      this.FormClosing += new
System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.KeyPress += new
System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
      this.ResumeLayout (false);
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
