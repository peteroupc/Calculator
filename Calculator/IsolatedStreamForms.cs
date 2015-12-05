using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.IsolatedStorage;

namespace Calculator {
    /// <summary>IsolatedStream abstraction for application-specific
    /// data.</summary>
  internal class IsolatedStream : IDisposable {
    private IsolatedStorageFile store;
    private Stream stream;

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
      GC.SuppressFinalize(this);
    }
  }
}
