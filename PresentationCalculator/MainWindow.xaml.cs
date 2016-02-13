using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PeterO.Calculator;
using Calculator;
namespace PresentationCalculator {
    /// <summary>Interaction logic for MainWindow.xaml.</summary>
  public partial class MainWindow : Window {
    private readonly CalculatorController cc;

    public MainWindow() {
      InitializeComponent();
      cc = new CalculatorController(new WpfWindowInfo(this));
      cc.InitializeConfig();
    }

    private void button_Click(object sender, RoutedEventArgs e) {
      cc.ClearButton();
    }

    private void button_Copy13_Click(object sender, RoutedEventArgs e) {
      cc.MultiplyButton();
    }

    private void button_Copy7_Click(object sender, RoutedEventArgs e) {
      cc.Digit(7);
    }

    private void button_Copy6_Click(object sender, RoutedEventArgs e) {
      cc.Digit(8);
    }

    private void button_Copy5_Click(object sender, RoutedEventArgs e) {
      cc.Digit(9);
    }

    private void Window_Closing(object sender,
      System.ComponentModel.CancelEventArgs e) {
      cc.SaveConfig();
    }

    private void button_Copy3_Click(object sender, RoutedEventArgs e) {
      cc.Digit(4);
    }

    private void button_Copy2_Click(object sender, RoutedEventArgs e) {
      cc.Digit(5);
    }

    private void button_Copy19_Click(object sender, RoutedEventArgs e) {
      cc.EqualsButton();
    }

    private void button_Copy11_Click(object sender, RoutedEventArgs e) {
      cc.Digit(0);
    }

    private void button_Copy9_Click_1(object sender, RoutedEventArgs e) {
      cc.PercentButton();
    }

    private void button_Copy8_Click(object sender, RoutedEventArgs e) {
      cc.SquareRootButton();
    }

    private void button_Copy4_Click(object sender, RoutedEventArgs e) {
      cc.AddButton();
    }

    private void button_Copy_Click(object sender, RoutedEventArgs e) {
      cc.SubtractButton();
    }

    private void button_Copy12_Click(object sender, RoutedEventArgs e) {
      cc.DivideButton();
    }

    private void button_Copy16_Click(object sender, RoutedEventArgs e) {
      cc.PlusMinusButton();
    }

    private void button_Copy17_Click(object sender, RoutedEventArgs e) {
      cc.DotButton();
    }

    private void button_Copy10_Click(object sender, RoutedEventArgs e) {
      cc.ClearEntryButton();
    }

 private void Calculator_TextInput(object sender, TextCompositionEventArgs
      e) {
      for (var i = 0; i < e.Text.Length; ++i) {
        cc.KeyPress(e.Text[i]);
      }
    }

    private void button_Copy1_Click(object sender, RoutedEventArgs e) {
      cc.Digit(6);
    }

    private void button_Copy18_Click(object sender, RoutedEventArgs e) {
      cc.Digit(1);
    }

    private void button_Copy15_Click(object sender, RoutedEventArgs e) {
      cc.Digit(2);
    }

    private void button_Copy14_Click(object sender, RoutedEventArgs e) {
      cc.Digit(3);
    }

    private void Calculator_PreviewKeyDown(object sender, KeyEventArgs e) {
      if (e.Key == Key.Enter) {
        this.cc.EqualsButton();
        e.Handled = true;
      }
      if (e.Key == Key.Back) {
        this.cc.BackButton();
        e.Handled = true;
      }
      if (e.Key == Key.Delete) {
        this.cc.ClearEntryButton();
        e.Handled = true;
      }
      if (e.Key == Key.Escape) {
        this.cc.ClearButton();
        e.Handled = true;
      }
    }
  }
}
