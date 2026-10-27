using System;
using System.IO;
using GeneralConsole;
using Task3;

namespace Task3Console {
public static class Ui {
  public static void Task3Ui() {
    string source = Helpers.ReadString("Введите путь к исходному файлу: ");
    string dest = Helpers.ReadString("Введите путь к копии файла: ");
    bool overwrite = false;

    if (Functions.FileExists(dest)) {
      Console.Write("Файл уже существует. Перезаписать? (y/n): ");

      string answer = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
      overwrite = answer == "y" || answer == "д";

      if (!overwrite) {
        Console.WriteLine("Копирование отменено.");
        return;
      }
    }

    try {
      Functions.CopyFile(source, dest, overwrite);

      Console.WriteLine("\nФайл скопирован: {0}", Path.GetFullPath(dest));
      Console.WriteLine(
        "Размер исходного файла: {0} байт",
        Functions.GetFileSize(source)
      );
      Console.WriteLine(
        "Размер копии: {0} байт",
        Functions.GetFileSize(dest)
      );
    }
    catch (Exception ex) {
      Console.WriteLine("Ошибка: {0}", ex.Message);
    }
  }
}
}
