namespace Calculator {
  internal interface IWindowInfo {
    double Left {
      get;
      set;
    }

    double Top {
      get;
      set;
    }

    double Width {
      get;
      set;
    }

    double Height {
      get;
      set;
    }

    void SetTextBox(string str);

    void ErrorSound();
  }
}
