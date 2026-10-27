using System;
using System.IO;
using GeneralConsole;
using Task1;

namespace Task1Console {
public static class Ui {
  private const int RandomMin = -50;
  private const int RandomMax = 50;

  public static void Task1Ui() {
    string path = Helpers.ReadString("Введите путь к двоичному файлу: ");
    int count = Helpers.ReadPositiveInt("Введите количество чисел: ");

    Console.WriteLine("1 - Ввести числа вручную");
    Console.WriteLine("2 - Заполнить случайными числами");

    int choice = Helpers.ReadInt("Выберите вариант: ");
    int[] numbers;

    if (choice == 1) {
      numbers = new int[count];

      for (int i = 0; i < count; i++) {
        numbers[i] = Helpers.ReadInt("A[" + i + "] = ");
      }
    }
    else if (choice == 2) {
      numbers = Functions.GenerateNumbers(count, RandomMin, RandomMax);
    }
    else {
      Console.WriteLine("Введено неверное значение!");
      return;
    }

    try {
      Functions.CreateFile(path, numbers);

      Console.WriteLine(
        "\nДвоичный файл создан: {0}",
        Path.GetFullPath(path)
      );

      Console.WriteLine(
        "Размер файла: {0} байт",
        Functions.GetFileSize(path)
      );

      int[] fromFile = Functions.ReadNumbers(path);

      Console.WriteLine(
        "Числа в файле: {0}",
        string.Join(" ", fromFile)
      );

      long product = Functions.ProductOfEven(fromFile, out int evenCount);

      if (evenCount == 0) {
        Console.WriteLine("Чётных чисел в файле нет.");
        return;
      }

      Console.WriteLine("Количество чётных чисел: {0}", evenCount);
      Console.WriteLine("Произведение чётных чисел: {0}", product);
    }
    catch (OverflowException) {
      Console.WriteLine(
        "Произведение чётных чисел слишком велико для типа long."
      );
    }
    catch (Exception ex) {
      Console.WriteLine("Ошибка: {0}", ex.Message);
    }
  }
}
}
