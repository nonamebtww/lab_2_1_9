using System;
using System.Collections.Generic;

namespace GeneralConsole {
public class Helpers {
  public static int ReadInt(string message) {
    while (true) {
      Console.Write(message);

      if (int.TryParse(
            Console.ReadLine(),
            out var result
          )) {
        return result;
      }

      Console.WriteLine(
        "Введено неверное значение!"
      );
    }
  }

  public static int ReadPositiveInt(string message) {
    while (true) {
      int result = ReadInt(message);

      if (result > 0) {
        return result;
      }

      Console.WriteLine(
        "Значение должно быть больше нуля!"
      );
    }
  }

  // Считывает непустую строку.
  public static string ReadString(string message) {
    while (true) {
      Console.Write(message);

      string result = Console.ReadLine();

      if (!string.IsNullOrWhiteSpace(result)) {
        return result.Trim();
      }

      Console.WriteLine(
        "Строка не должна быть пустой!"
      );
    }
  }

  // Считывает многострочный текст.
  // Ввод заканчивается пустой строкой.
  public static string ReadText(string message) {
    Console.WriteLine(message);
    Console.WriteLine("(для окончания ввода введите пустую строку)");

    List<string> lines = new List<string>();

    while (true) {
      string line = Console.ReadLine();

      if (string.IsNullOrEmpty(line)) {
        break;
      }

      lines.Add(line);
    }

    return string.Join(Environment.NewLine, lines);
  }

  public static void Pause() {
    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
    Console.ReadKey(true);
  }
}
}
