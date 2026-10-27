using System;
using System.Windows.Forms;
using FunctionsTask2 = Task2.Functions;

namespace Task2WinForms {
public partial class Task2Page : UserControl {

  public Task2Page() {
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

  private static string NumbersToText(int[] numbers) {
    return numbers.Length == 0
      ? "(файл пуст)"
      : string.Join(" ", numbers);
  }

  private void btnBrowse_Click(object sender, EventArgs e) {
    if (openDialog.ShowDialog() == DialogResult.OK) {
      boxPath.Text = openDialog.FileName;
    }
  }

  private void btnRead_Click(object sender, EventArgs e) {
    string path = boxPath.Text.Trim();

    if (string.IsNullOrEmpty(path)) {
      ShowError("Укажите путь к файлу.");
      return;
    }

    boxPosition.Text = string.Empty;
    boxAfter.Text = string.Empty;

    try {
      boxBefore.Text = NumbersToText(FunctionsTask2.ReadNumbers(path));
    }
    catch (Exception ex) {
      boxBefore.Text = string.Empty;
      ShowError(ex.Message);
    }
  }

  private void btnInsert_Click(object sender, EventArgs e) {
    string path = boxPath.Text.Trim();

    if (string.IsNullOrEmpty(path)) {
      ShowError("Укажите путь к файлу.");
      return;
    }

    if (!int.TryParse(boxNumber.Text, out int number)) {
      ShowError("Введите корректное целое число.");
      return;
    }

    try {
      int[] before = FunctionsTask2.ReadNumbers(path);
      int index = FunctionsTask2.InsertAtRandomPosition(path, number);
      int[] after = FunctionsTask2.ReadNumbers(path);

      boxBefore.Text = NumbersToText(before);
      boxPosition.Text = (index + 1) + " из " + after.Length;
      boxAfter.Text = NumbersToText(after);
    }
    catch (Exception ex) {
      ShowError(ex.Message);
    }
  }
}
}
