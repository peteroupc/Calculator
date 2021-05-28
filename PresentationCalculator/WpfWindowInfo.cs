using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Calculator {
  /// <summary>WPF implementation of IWindowInfo.</summary>
  class WpfWindowInfo : IWindowInfo {
    private readonly Window form;
    public WpfWindowInfo (Window form) {
      this.form = form;
    }
    public double Height {
      get {
        return form.Height;
      }

      set {
        form.Height = value;
      }
    }

    public double Left {
      get {
        return form.Left;
      }

      set {
        form.Left = value;
      }
    }

    public double Width {
      get {
        return form.Width;
      }

      set {
        form.Width = value;
      }
    }

    public double Top {
      get {
        return form.Top;
      }

      set {
        form.Top = value;
      }
    }

    public void SetTextBox (string str) {
      var tb = (TextBlock)form.FindName ("text");
      tb.Text = str;
    }

    public void ErrorSound() {
      System.Media.SystemSounds.Beep.Play();
    }
  }
}
