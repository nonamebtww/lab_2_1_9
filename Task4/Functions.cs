using System;
using System.IO;
using System.Text;

namespace Task4 {
public static class Functions {
  // Проверяет, что файл существует.
  private static void CheckExists(string path) {
    if (!File.Exists(path)) {
      throw new FileNotFoundException(
        "Файл \"" + path + "\" не найден."
      );
    }
  }

  // Время создания файла - метод File.GetCreationTime().
  public static DateTime GetCreationTime(string path) {
    CheckExists(path);
    return File.GetCreationTime(path);
  }

  // Время последнего доступа к файлу - метод File.GetLastAccessTime().
  public static DateTime GetLastAccessTime(string path) {
    CheckExists(path);
    return File.GetLastAccessTime(path);
  }

  // Время последней записи в файл - метод File.GetLastWriteTime().
  public static DateTime GetLastWriteTime(string path) {
    CheckExists(path);
    return File.GetLastWriteTime(path);
  }

  // Формирует текст со сведениями о файле.
  public static string GetInfoText(string path) {
    StringBuilder builder = new StringBuilder();

    builder.AppendLine("Файл: " + Path.GetFullPath(path));
    builder.AppendLine("Время создания: " + GetCreationTime(path));
    builder.AppendLine("Время последнего доступа: " + GetLastAccessTime(path));
    builder.AppendLine("Время последней записи: " + GetLastWriteTime(path));

    return builder.ToString();
  }

  // Сохраняет сведения о файле в текстовый файл
  // с помощью класса StreamWriter.
  public static void SaveInfo(string savePath, string info) {
    StreamWriter writer = new StreamWriter(savePath, false, Encoding.UTF8);

    try {
      writer.Write(info);
    }
    finally {
      writer.Close();
    }
  }
}
}
