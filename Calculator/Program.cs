/*
Written by Peter O. in 2014.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.dreamhosters.com/articles/donate-now-2/
 */
using System;
using System.Windows.Forms;

namespace Calculator {
    /// <summary>Class with program entry point.</summary>
  internal sealed class Program {
    /// <summary>Program entry point.</summary>
    [STAThread]
    private static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      using (var mainForm = new MainForm()) {
        Application.Run(mainForm);
      }
    }
  }
}
