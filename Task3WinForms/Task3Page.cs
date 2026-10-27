using System;
using System.Windows.Forms;
using FunctionsTask3 = Task3.Functions;

namespace Task3WinForms {
public partial class Task3Page : UserControl {

  public Task3Page() {
    InitializeComponent();
  }

  private static void ShowError(string message) {
    MessageBox.Show(
      message,
      "Ошибка",
      MessageBoxButtons.OK,
      MessageBoxIcon.Error
    );
  }

  private void btnBrowseSource_Click(object sender, EventArgs e) {
    if (openDialog.ShowDialog() == DialogResult.OK) {
      boxSource.Text = openDialog.FileName;
    }
  }

  private void btnBrowseDest_Click(object sender, EventArgs e) {
    if (saveDialog.ShowDialog() == DialogResult.OK) {
      boxDest.Text = saveDialog.FileName;
    }
  }

  private void btnCopy_Click(object sender, EventArgs e) {
    string source = boxSource.Text.Trim();
    string dest = boxDest.Text.Trim();

    if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(dest)) {
      ShowError("Укажите исходный файл и путь к копии.");
      return;
    }

    boxResult.Text = string.Empty;

    try {
      FunctionsTask3.CopyFile(source, dest, checkOverwrite.Checked);

      boxResult.Text =
        "Файл скопирован: " + dest + Environment.NewLine +
        "Размер исходного файла: " +
        FunctionsTask3.GetFileSize(source) + " байт" + Environment.NewLine +
        "Размер копии: " +
        FunctionsTask3.GetFileSize(dest) + " байт";
    }
    catch (Exception ex) {
      ShowError(ex.Message);
    }
  }
}
}
