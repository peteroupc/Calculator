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
    /// <param name='args'>A string[] object.</param>
    [STAThread]
    private static void Main(string[] args) {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
