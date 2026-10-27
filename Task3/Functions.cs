using System.IO;

namespace Task3 {
public static class Functions {
  // Копирует файл sourcePath в файл destPath методом File.Copy().
  // Если overwrite = false и целевой файл существует,
  // генерируется исключение IOException.
  public static void CopyFile(string sourcePath, string destPath, bool overwrite) {
    if (!File.Exists(sourcePath)) {
      throw new FileNotFoundException(
        "Исходный файл \"" + sourcePath + "\" не найден."
      );
    }

    if (Path.GetFullPath(sourcePath) == Path.GetFullPath(destPath)) {
      throw new IOException(
        "Исходный и целевой файл совпадают."
      );
    }

    File.Copy(sourcePath, destPath, overwrite);
  }

  // Проверяет, существует ли файл, методом File.Exists().
  public static bool FileExists(string path) {
    return File.Exists(path);
  }

  // Возвращает размер файла в байтах.
  public static long GetFileSize(string path) {
    return new FileInfo(path).Length;
  }
}
}
