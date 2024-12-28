using System;
using System.Windows.Forms;

namespace Calculator {
  /// <summary>Windows Forms implementation of IWindowInfo.</summary>
  internal class FormWindowInfo : IWindowInfo {
    private readonly Form form;

    public FormWindowInfo(Form form) {
      this.form = form;
    }

    public double Height {
      get {
        return this.form.Height;
      }

      set {
        this.form.Height = (int)Math.Round(value);
      }
    }

    public double Left {
      get {
        return this.form.Left;
      }

      set {
        this.form.Left = (int)Math.Round(value);
      }
    }

    public double Width {
      get {
        return this.form.Width;
      }

      set {
        this.form.Width = (int)Math.Round(value);
      }
    }

    public double Top {
      get {
        return this.form.Top;
      }

      set {
        this.form.Top = (int)Math.Round(value);
      }
    }

    public void SetTextBox(string str) {
      this.form.Controls["text"].Text = str;
    }

    public void ErrorSound() {
      System.Media.SystemSounds.Beep.Play();
    }
  }
}
