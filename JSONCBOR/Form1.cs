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
using Calculator;

namespace JSONCBOR {
/// </summary>
public partial class Form1 : Form {
    private CBORObject cborData = null;
    private string cborFile = null;
    private string jsonFile = null;
    private CBORObject jsonData = null;
    private ProgramConfig config = null;

    public Form1() {
      this.InitializeComponent();
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
      ofd.FileOk += this.JsonFileOk;
      ofd.ShowDialog();
    }

    private void JsonFileOk(object sender, CancelEventArgs e) {
      var ofd = (OpenFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          this.jsonData = CBORObject.ReadJSON(stream);
          this.jsonLabel.Text = ofd.FileName;
          this.jsonFile = ofd.FileName;
          this.convertToCbor.Enabled = true;
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
      ofd.FileOk += this.CborFileOk;
      ofd.ShowDialog();
    }

    private void CborFileOk(object sender, CancelEventArgs e) {
      var ofd = (OpenFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          this.cborData = CBORObject.Read(stream);
          this.cborLabel.Text = ofd.FileName;
          this.cborFile = ofd.FileName;
          this.convertToJson.Enabled = true;
        } catch (CBORException) {
          MessageBox.Show("Not a CBOR file.");
          e.Cancel = false;
        }
      }
    }

    private void convertToCbor_Click(object sender, EventArgs e) {
      var ofd = new SaveFileDialog();
      ofd.AddExtension = true;
      ofd.FileName = System.IO.Path.ChangeExtension(this.jsonFile, ".cbor");
      ofd.DefaultExt = ".cbor";
      ofd.Filter = "CBOR files (*.cbor)|*.cbor|All files (*.*)|*.*";
      ofd.AutoUpgradeEnabled = true;
      ofd.CheckFileExists = false;
      ofd.CheckPathExists = true;
      ofd.RestoreDirectory = false;
      ofd.FileOk += this.CborConvertOk;
      ofd.ShowDialog();
    }

    private void CborConvertOk(object sender, CancelEventArgs e) {
      var ofd = (SaveFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          this.jsonData.WriteTo(stream);
        } catch (System.IO.IOException) {
          MessageBox.Show("Failed to write to the file.");
        }
      }
    }

    private void convertToJson_Click(object sender, EventArgs e) {
      var ofd = new SaveFileDialog();
      ofd.AddExtension = true;
      ofd.FileName = System.IO.Path.ChangeExtension(this.cborFile, ".json");
      ofd.DefaultExt = ".json";
      ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
      ofd.AutoUpgradeEnabled = true;
      ofd.CheckFileExists = false;
      ofd.CheckPathExists = true;
      ofd.RestoreDirectory = false;
      ofd.FileOk += this.JsonConvertOk;
      ofd.ShowDialog();
    }

    private void JsonConvertOk(object sender, CancelEventArgs e) {
      var ofd = (SaveFileDialog)sender;
      using (var stream = ofd.OpenFile()) {
        try {
          this.cborData.WriteJSONTo(stream);
        } catch (System.IO.IOException) {
          MessageBox.Show("Failed to write to the file.");
        }
      }
    }

    private void Form1_Load(object sender, EventArgs e) {
      this.config = new ProgramConfig("config").FormPosFromConfig(this);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      this.config.FormPosToConfig(this).Save();
    }
  }
}
