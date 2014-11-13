/*
 * Created by SharpDevelop.
 * User: Peter
 * Date: 11/13/2014
 * Time: 5:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;


namespace Calculator
{
  /// <summary>
  /// Description of MainForm.
  /// </summary>
  public partial class MainForm : Form
  {
    readonly CalculatorState state;
    
    public MainForm()
    {
      //
      // The InitializeComponent() call is required for Windows Forms designer support.
      //
      InitializeComponent();
      state=new CalculatorState();
    }
    private void Digit(int digit){
      state.DigitButton(digit);
      text.Text=state.Text;
    }
    
		void MainFormLoad(object sender, EventArgs e) {
      text.Text=state.Text;
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
      text.Text=state.Text;
		}
		void Button14Click(object sender, EventArgs e) {
      state.EqualsButton();
      text.Text=state.Text;
		}
		void Button3Click(object sender, EventArgs e) {
      Digit(3);
		}
		void Button21Click(object sender, EventArgs e) {
		  // not implemented yet
    }
		void Button8Click(object sender, EventArgs e) {
      state.SubtractButton();
      text.Text=state.Text;
		}
		void Button12Click(object sender, EventArgs e) {
      state.MultiplyButton();
      text.Text=state.Text;
		}
		void Button16Click(object sender, EventArgs e) {
      state.DivideButton();
      text.Text=state.Text;
		}
		void Button20Click(object sender, EventArgs e) {
      state.DotButton();
      text.Text=state.Text;
		}
		void Button17Click(object sender, EventArgs e) {
      state.Clear();
      text.Text=state.Text;
		}
  }
}
