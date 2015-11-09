using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using PeterO.Cbor;

namespace Calculator {
    /// <summary>Holds a program's configuration data. Uses CBOR as the
    /// serialization format.</summary>
  internal class ProgramConfig {
    internal CBORObject config;
    internal string file;

    public ProgramConfig(string configName) {
      this.file = configName + ".cbor";
      if (File.Exists(this.file)) {
        using (var fs = new FileStream(this.file, FileMode.Open)) {
          try {
            this.config = CBORObject.Read(fs);
          } catch (CBORException) {
            this.config = null;
          }
        }
      }
      this.config = this.config ?? CBORObject.NewMap();
    }

    public ProgramConfig Save() {
      using (var fs = new FileStream(this.file, FileMode.Create)) {
        this.config.WriteTo(fs);
      }
      return this;
    }

    public ProgramConfig SetObject(string name, object obj) {
      this.config.Set(name, obj);
      return this;
    }

    public string GetString(string name) {
      if (!this.config.ContainsKey(name)) {
        return null;
      } else {
        CBORObject value = this.config[name];
      return (value.Type != CBORType.TextString) ? null : (value.AsString());
      }
    }

    public int GetInt32OrDefault(string name, int defaultValue) {
      if (!this.config.ContainsKey(name)) {
        return defaultValue;
      } else {
        int ret = 0;
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

    public double GetDouble(string name) {
      if (!this.config.ContainsKey(name)) {
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
