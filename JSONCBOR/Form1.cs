using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeterO.Cbor;

namespace JSONCBOR {
/// </summary>
public partial class Form1 : Form {
    CBORObject cborData = null;
    string cborFile = null;
    string jsonFile = null;
    CBORObject jsonData = null;

    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      var ofd = new OpenFileDialog();
      ofd.AddExtension = true;
      ofd.DefaultExt = ".json";
      ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
      ofd.AutoUpgradeEnabled = true;
      ofd.CheckFileExists = true;
      ofd.CheckPathExists = true;
      ofd.RestoreDirectory = false;
      ofd.FileOk += JsonFileOk;
      ofd.ShowDialog();
    }

    private void JsonFileOk(object sender, CancelEventArgs e) {
      var ofd = (OpenFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          jsonData = CBORObject.ReadJSON(stream);
          jsonLabel.Text = ofd.FileName;
          jsonFile = ofd.FileName;
          convertToCbor.Enabled = true;
        } catch (CBORException) {
          MessageBox.Show("Not a JSON file.");
          e.Cancel = false;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      var ofd = new OpenFileDialog();
      ofd.AddExtension = true;
      ofd.DefaultExt = ".cbor";
      ofd.Filter = "CBOR files (*.cbor)|*.cbor|All files (*.*)|*.*";
      ofd.AutoUpgradeEnabled = true;
      ofd.CheckFileExists = true;
      ofd.CheckPathExists = true;
      ofd.RestoreDirectory = false;
      ofd.FileOk += CborFileOk;
      ofd.ShowDialog();
    }

    private void CborFileOk(object sender, CancelEventArgs e) {
      var ofd = (OpenFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          cborData = CBORObject.Read(stream);
          cborLabel.Text = ofd.FileName;
          cborFile = ofd.FileName;
          convertToJson.Enabled = true;
        } catch (CBORException) {
          MessageBox.Show("Not a CBOR file.");
          e.Cancel = false;
        }
      }
    }

    private void convertToCbor_Click(object sender, EventArgs e) {
      var ofd = new SaveFileDialog();
      ofd.AddExtension = true;
      ofd.FileName = System.IO.Path.ChangeExtension(jsonFile,".cbor");
      ofd.DefaultExt = ".cbor";
      ofd.Filter = "CBOR files (*.cbor)|*.cbor|All files (*.*)|*.*";
      ofd.AutoUpgradeEnabled = true;
      ofd.CheckFileExists = false;
      ofd.CheckPathExists = true;
      ofd.RestoreDirectory = false;
      ofd.FileOk += CborConvertOk;
      ofd.ShowDialog();
    }

    private void CborConvertOk(object sender, CancelEventArgs e) {
      var ofd = (SaveFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          jsonData.WriteTo(stream);
        } catch (System.IO.IOException) {
          MessageBox.Show("Failed to write to the file.");
        }
      }
    }

    private void convertToJson_Click(object sender, EventArgs e) {
      var ofd = new SaveFileDialog();
      ofd.AddExtension = true;
      ofd.FileName = System.IO.Path.ChangeExtension(cborFile, ".json");
      ofd.DefaultExt = ".json";
      ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
      ofd.AutoUpgradeEnabled = true;
      ofd.CheckFileExists = false;
      ofd.CheckPathExists = true;
      ofd.RestoreDirectory = false;
      ofd.FileOk += JsonConvertOk;
      ofd.ShowDialog();
    }

    private void JsonConvertOk(object sender, CancelEventArgs e) {
      var ofd = (SaveFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          cborData.WriteJSONTo(stream);
        } catch (System.IO.IOException) {
          MessageBox.Show("Failed to write to the file.");
        }
      }
    }
  }
}
