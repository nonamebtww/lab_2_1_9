using System;
using System.Windows.Forms;
using FunctionsTask1 = Task1.Functions;

namespace Task1WinForms {
  public partial class Task1Page : UserControl {
    private const int RandomMin = -50;
    private const int RandomMax = 50;

    public Task1Page() {
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
      if (saveDialog.ShowDialog() == DialogResult.OK) {
        boxPath.Text = saveDialog.FileName;
      }
    }

    private void btnRandom_Click(object sender, EventArgs e) {
      if (!int.TryParse(
        boxCount.Text,
        out int count
      ) || count <= 0) {
        ShowError("Введите корректное количество чисел.");
        return;
      }

      int[] numbers = FunctionsTask1.GenerateNumbers(
        count,
        RandomMin,
        RandomMax
      );

      boxNumbers.Text = string.Join(" ", numbers);
    }

    private void btnCreate_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(boxPath.Text)) {
        ShowError("Укажите путь к файлу.");
        return;
      }

      string[] parts = boxNumbers.Text
        .Split(
          new[] { ' ', '\r', '\n', '\t', ';' },
          StringSplitOptions.RemoveEmptyEntries
        );

      if (parts.Length == 0) {
        ShowError("Введите числа.");
        return;
      }

      int[] numbers = new int[parts.Length];

      for (int i = 0; i < parts.Length; i++) {
        if (!int.TryParse(parts[i], out numbers[i])) {
          ShowError("Введено некорректное целое число: " + parts[i]);
          return;
        }
      }

      try {
        FunctionsTask1.CreateFile(boxPath.Text, numbers);
      }
      catch (Exception ex) {
        ShowError(ex.Message);
        return;
      }

      MessageBox.Show(
        "Файл создан.",
        "Готово",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }

    private void btnCalculate_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(boxPath.Text)) {
        ShowError("Укажите путь к файлу.");
        return;
      }

      boxContent.Text = string.Empty;
      boxEvenCount.Text = string.Empty;
      boxProduct.Text = string.Empty;

      int[] numbers;

      try {
        numbers = FunctionsTask1.ReadNumbers(boxPath.Text);
      }
      catch (Exception ex) {
        ShowError(ex.Message);
        return;
      }

      boxContent.Text = string.Join(" ", numbers);

      try {
        long product = FunctionsTask1.ProductOfEven(
          numbers,
          out int evenCount
        );

        boxEvenCount.Text = evenCount.ToString();
        boxProduct.Text = evenCount == 0
          ? "Чётных чисел нет"
          : product.ToString();
      }
      catch (OverflowException) {
        ShowError("Произведение чётных чисел слишком велико для типа long.");
      }
    }
  }
}
