## Introduction

This article includes information on how a calculator program is implemented
using [my CBOR library for C#](http://www.codeproject.com/Tips/897294/Concise-Binary-Object-Representation-CBOR-in-Cshar).
(CBOR stands for Concise Binary Object Representation.)

![Calculator](calc.png)

While it looks relatively simple, the [calculator program](https://github.com/peteroupc/Calculator) demonstrates two features of that library:

* Its support for arbitrary precision arithmetic.
* Reading and writing data in CBOR.

These two features will be discussed in turn.

## Arbitrary-Precision Arithmetic

The main purpose of the program, of course, is to do calculations.  This calculator program
is powered by my CBOR library's support for arbitrary-precision decimal arithmetic.  While
`double`, a 64-bit binary floating point number type, is appropriate for most purposes, it can
sometimes provide unintuitive results, due to using a binary rather than a
decimal system.

TODO: Discuss CalculatorState.

## Storing Application Settings

CBOR's compact data format suits it well for storing things such as user settings.

The calculator program demonstrates this; when the program exits, it gets the window's current
position and size, stores them in a user settings object, and converts the user settings
object to a CBOR file.

The `ProgramConfig` class is used to store user settings.  It has these methods:

    public ProgramConfig(string configName);
    public ProgramConfig SetObject(string name, object obj);
    public string GetString(string name);
    public int GetInt32OrDefault(string name, int defaultValue);
    public double GetDouble(string name);

In case the program is installed in what can be a read-only location, such as the Program
Files folder, the calculator stores user settings in per-user application storage.  This is
possible with the `System.IO.IsolatedStorage` namespace supported in .NET 4. (Windows
Store apps use a separate concept for application storage, which isn't supported in the
demo, but which can be easily added due to the nature of the implementation, as
discussed below.)

### Loading and Saving

The ProgramConfig constructor opens a named file from per-user storage (with the ".cbor"
extension, since it loads and saves CBOR files), and generates blank user data if the
file doesn't exist (which is usually the case when the program is first run) or the file contains
invalid data.  The calculator creates a ProgramConfig constructor on load of the form
(see `MainForm.cs`):

    private void MainForm_Load(object sender, EventArgs e) {
      // Initialize config here, rather than in the constructor;
      // the system may automatically move the window in between
      this.config = this.InitializeConfig();
    }

    private ProgramConfig InitializeConfig() {
      return new ProgramConfig("config").FormPosFromConfig(this);
    }

On the first run, the ProgramConfig is generated and populated with default values
for the window's current position as it's loaded for the first time (due to the
`FormPosFromConfig` method).

As the program is closing, it retrieves the window's current position and saves
the user data to per-user storage:

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      this.SaveConfig();
    }

    private void SaveConfig() {
      if (this.config != null) {
        this.config.FormPosToConfig(this).Save();
      }
    }

As a result, the last used window position and size are restored if the user runs
the program again.

It's also possible to save user data while the program is running (for instance, after
the user changes a program setting) or to access settings at runtime, but these
possibilities are currently not demonstrated in the calculator program.

### Reading and Writing Settings

To be written.

### ProgramConfig implementation

I've made the ProgramConfig class general enough that it can be used in many different
kinds of programs; for instance, it's also used in [another demo program of
mine](https://github.com/peteroupc/Calculator/JSONCBOR) that converts JSON
to CBOR and back.  In this program, too, saves the last known window position
and size in the same way as the calculator demo.  Since it's specific to Windows
Forms programs, certain "methods" of ProgramConfig were designed as extension
methods and placed in a separate class, `FormConfig`.

However, while `ProgramConfig` is very general, it relies on isolated storage, which
unfortunately isn't supported in Windows Store apps, which use a very different
concept for per-user storage.  This is why ProgramConfig contains a nested
class called `IsolatedStream`, which is designed to wrap the details of the per-user
storage implementation.  If a version for Windows Store apps is needed,
`IsolatedStream` can be updated to provide or call a Windows-Store-specific
implementation of per-user storage.  This isn't done here, since the main purpose
is to demonstate the features of my CBOR library.
