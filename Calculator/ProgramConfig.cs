using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

using PeterO.Cbor;

namespace Calculator {
    /// <summary>Holds a program's configuration data. Uses CBOR as the
    /// serialization format.</summary>
  internal class ProgramConfig {
    private CBORObject config;
    private string file;

    /// <summary>IsolatedStream abstraction for application-specific data.
    /// Currently
    /// this only works for .NET Framework applications.</summary>
    private class IsolatedStream : IDisposable {
      internal IsolatedStorageFile store;
      internal Stream stream;

      public IsolatedStream(string name, bool write) {
        this.store = IsolatedStorageFile.GetStore(
          IsolatedStorageScope.Domain | IsolatedStorageScope.User | IsolatedStorageScope.Assembly,
          null,
          null);
        if (this.store.FileExists(name) || write) {
          this.stream = new IsolatedStorageFileStream(
            name,
            write ? FileMode.Create : FileMode.Open);
        }
      }

      public Stream Stream {
        get {
 return this.stream;
}
      }

      public void Dispose() {
        if (this.store != null) {
 this.store.Dispose();
}
        if (this.stream != null) {
 this.stream.Dispose();
}
        this.store = null;
        this.stream = null;
      }
    }

   public ProgramConfig(string configName) {
      this.file = configName + ".cbor";
        using (var fs = new IsolatedStream(this.file, false)) {
          if (fs.Stream != null) {
            try {
              this.config = CBORObject.Read(fs.Stream);
            } catch (CBORException) {
              this.config = null;
            }
          }
        }
      this.config = this.config ?? CBORObject.NewMap();
    }

    public ProgramConfig Save() {
      using (var fs = new IsolatedStream(this.file, true)) {
        this.config.WriteTo(fs.Stream);
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
      return (value.Type != CBORType.TextString) ? null : value.AsString();
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
