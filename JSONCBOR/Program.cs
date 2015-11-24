using System;
using System.Windows.Forms;

namespace JSONCBOR {
  internal static class Program {
    /// <summary>The main entry point for the application.</summary>
    [STAThread]
    internal static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      using (var form1 = new Form1()) {
        Application.Run(form1);
      }
    }
  }
}
