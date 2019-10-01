using System;

namespace Calculator {
  internal static class FormConfig {
    public static ProgramConfig FormPosFromConfig(
      this ProgramConfig config,
      IWindowInfo form) {
      var x = config.GetDoubleOrDefault("x", form.Left);
      var y = config.GetDoubleOrDefault("y", form.Top);
      var width = config.GetDoubleOrDefault("width", form.Width);
      var height = config.GetDoubleOrDefault("height", form.Height);
      form.Left = Math.Max(0, x);
      form.Top = Math.Max(0, y);
      form.Width = Math.Max(0, width);
      form.Height = Math.Max(0, height);
      return config;
    }

    public static ProgramConfig FormPosToConfig(
      this ProgramConfig config,
      IWindowInfo form) {
      return config.SetObject("x", form.Left).SetObject("y", form.Top)
          .SetObject("width", form.Width).SetObject("height", form.Height);
    }
  }
}
