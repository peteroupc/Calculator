using System;
using PeterO.Cbor;

namespace Calculator {
  /// <summary>Holds a program's configuration data. Uses CBOR as the
  /// serialization format.</summary>
  internal class ProgramConfig {
    private readonly CBORObject config;
    private readonly string file;

    public ProgramConfig (string configName) {
      this.file = configName + ".cbor";
      using (var fs = new IsolatedStream(this.file, false)) {
        if (fs.Stream != null) {
          try {
            this.config = CBORObject.Read (fs.Stream);
          } catch (CBORException) {
            this.config = null;
          }
        }
      }
      this.config = this.config ?? CBORObject.NewMap();
    }

    public ProgramConfig Save() {
      using (var fs = new IsolatedStream(this.file, true)) {
        this.config.WriteTo (fs.Stream);
      }
      return this;
    }

    public ProgramConfig SetObject (string name, object obj) {
      this.config.Set (name, obj);
      return this;
    }

    public string GetString (string name) {
      if (!this.config.ContainsKey (name)) {
        return null;
      } else {
        var value = this.config[name];
        return (value.Type != CBORType.TextString) ? null : value.AsString();
      }
    }

    public int GetInt32OrDefault (string name, int defaultValue) {
      if (!this.config.ContainsKey (name)) {
        return defaultValue;
      } else {
        var ret = 0;
        try {
          ret = this.config[name].AsInt32();
        } catch (InvalidOperationException) {
          return defaultValue;
        } catch (OverflowException) {
          return defaultValue;
        }
        return ret;
      }
    }

    public double GetDoubleOrDefault (string name, double defaultValue) {
      if (!this.config.ContainsKey (name)) {
        return defaultValue;
      } else {
        var ret = 0.0;
        try {
          ret = this.config[name].AsDouble();
        } catch (InvalidOperationException) {
          return defaultValue;
        } catch (OverflowException) {
          return defaultValue;
        }
        return ret;
      }
    }

    public double GetDouble (string name) {
      if (!this.config.ContainsKey (name)) {
        return Double.NaN;
      } else {
        double ret = 0;
        try {
          ret = this.config[name].AsDouble();
        } catch (InvalidOperationException) {
          return Double.NaN;
        }
        return ret;
      }
    }
  }
}
