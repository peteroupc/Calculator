using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Calculator {
  internal static class FormConfig {
    public static ProgramConfig FormPosFromConfig(
this ProgramConfig config,
Form form) {
      int x = config.GetInt32OrDefault("x", form.Left);
      int y = config.GetInt32OrDefault("y", form.Top);
      int width = config.GetInt32OrDefault("width", form.Width);
      int height = config.GetInt32OrDefault("height", form.Height);
      form.Left = Math.Max(0, x);
      form.Top = Math.Max(0, y);
      form.Width = Math.Max(0, width);
      form.Height = Math.Max(0, height);
      return config;
    }

    public static ProgramConfig FormPosToConfig(
this ProgramConfig config,
Form form) {
      return config.SetObject("x", form.Left).SetObject("y", form.Top)
          .SetObject("width", form.Width).SetObject("height", form.Height);
    }
  }
}
