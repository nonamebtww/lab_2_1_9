using System;
using GeneralConsole;

namespace AppConsole {
  internal class Program {
    private static void Main(string[] args) {
      while (true) {
        Console.Clear();

        Console.Write(
          "Задания:\n" +
          "1. Задание 1 - произведение чётных чисел из двоичного файла\n" +
          "2. Задание 2 - вставка числа в случайную позицию файла\n" +
          "3. Задание 3 - копирование файла\n" +
          "4. Задание 4 - информация о файле\n" +
          "0. Выход\n" +
          "Введите действие: "
        );

        switch (Console.ReadLine()) {
            case "1":
              Task1Console.Ui.Task1Ui();
              Helpers.Pause();
              break;
            case "2":
              Task2Console.Ui.Task2Ui();
              Helpers.Pause();
              break;
            case "3":
              Task3Console.Ui.Task3Ui();
              Helpers.Pause();
              break;
            case "4":
              Task4Console.Ui.Task4Ui();
              Helpers.Pause();
              break;
            case "0":
              return;
            default:
              Console.WriteLine("Введено неверное значение!");
              Helpers.Pause();
              break;
        }
      }
    }
  }
}
