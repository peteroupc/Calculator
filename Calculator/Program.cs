/*
Written by Peter O.
Any copyright to this work is released to the Public Domain.
In case this is not possible, this work is also
licensed under Creative Commons Zero (CC0):
https://creativecommons.org/publicdomain/zero/1.0/

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
      Application.SetCompatibleTextRenderingDefault (false);
      using (var mainForm = new MainForm()) {
        Application.Run (mainForm);
      }
    }
  }
}
