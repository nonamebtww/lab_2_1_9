using System;
using System.IO;
using GeneralConsole;
using Task4;

namespace Task4Console {
public static class Ui {
  public static void Task4Ui() {
    string path = Helpers.ReadString("Введите путь к файлу: ");
    string info;

    try {
      info = Functions.GetInfoText(path);
    }
    catch (Exception ex) {
      Console.WriteLine("Ошибка: {0}", ex.Message);
      return;
    }

    Console.WriteLine("\nИнформация о файле:");
    Console.Write(info);

    string savePath = Helpers.ReadString(
      "\nВведите путь к файлу для сохранения информации: "
    );

    try {
      Functions.SaveInfo(savePath, info);

      Console.WriteLine(
        "Информация сохранена в файл: {0}",
        Path.GetFullPath(savePath)
      );
    }
    catch (Exception ex) {
      Console.WriteLine("Ошибка: {0}", ex.Message);
    }
  }
}
}
