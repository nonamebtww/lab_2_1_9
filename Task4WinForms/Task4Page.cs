using System;
using System.Windows.Forms;
using FunctionsTask4 = Task4.Functions;

namespace Task4WinForms {
public partial class Task4Page : UserControl {

  public Task4Page() {
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

  private void btnBrowse_Click(object sender, EventArgs e) {
    if (openDialog.ShowDialog() == DialogResult.OK) {
      boxPath.Text = openDialog.FileName;
    }
  }

  private void btnBrowseSave_Click(object sender, EventArgs e) {
    if (saveDialog.ShowDialog() == DialogResult.OK) {
      boxSave.Text = saveDialog.FileName;
    }
  }

  private void btnInfo_Click(object sender, EventArgs e) {
    string path = boxPath.Text.Trim();

    if (string.IsNullOrEmpty(path)) {
      ShowError("Укажите путь к файлу.");
      return;
    }

    boxCreation.Text = string.Empty;
    boxAccess.Text = string.Empty;
    boxWrite.Text = string.Empty;

    try {
      boxCreation.Text = FunctionsTask4.GetCreationTime(path).ToString();
      boxAccess.Text = FunctionsTask4.GetLastAccessTime(path).ToString();
      boxWrite.Text = FunctionsTask4.GetLastWriteTime(path).ToString();
    }
    catch (Exception ex) {
      ShowError(ex.Message);
    }
  }

  private void btnSave_Click(object sender, EventArgs e) {
    string path = boxPath.Text.Trim();
    string savePath = boxSave.Text.Trim();

    if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(savePath)) {
      ShowError("Укажите файл и путь для сохранения информации.");
      return;
    }

    try {
      string info = FunctionsTask4.GetInfoText(path);
      FunctionsTask4.SaveInfo(savePath, info);

      MessageBox.Show(
        "Информация сохранена в файл:" + Environment.NewLine + savePath,
        "Готово",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }
    catch (Exception ex) {
      ShowError(ex.Message);
    }
  }
}
}
