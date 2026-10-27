using System;
using GeneralConsole;
using Task2;

namespace Task2Console {
public static class Ui {
  public static void Task2Ui() {
    string path = Helpers.ReadString(
      "Введите путь к двоичному файлу из задания 1: "
    );

    try {
      int[] before = Functions.ReadNumbers(path);

      Console.WriteLine(
        "Числа в файле до вставки: {0}",
        before.Length == 0 ? "(файл пуст)" : string.Join(" ", before)
      );

      int number = Helpers.ReadInt("Введите число для вставки: ");
      int index = Functions.InsertAtRandomPosition(path, number);

      Console.WriteLine(
        "\nЧисло {0} вставлено в позицию {1} из {2}.",
        number,
        index + 1,
        before.Length + 1
      );

      int[] after = Functions.ReadNumbers(path);

      Console.WriteLine(
        "Числа в файле после вставки: {0}",
        string.Join(" ", after)
      );
    }
    catch (Exception ex) {
      Console.WriteLine("Ошибка: {0}", ex.Message);
    }
  }
}
}
