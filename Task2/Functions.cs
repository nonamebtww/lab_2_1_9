using System;
using System.IO;

namespace Task2 {
public static class Functions {
  private static readonly Random Random = new Random();

  // Считывает числа из двоичного файла (функция задания 1).
  public static int[] ReadNumbers(string path) {
    return Task1.Functions.ReadNumbers(path);
  }

  // Вставляет число number в случайно выбранную позицию
  // двоичного файла с целыми числами.
  // Возвращает номер позиции (с нуля), куда было вставлено число.
  public static int InsertAtRandomPosition(string path, int number) {
    FileStream file = new FileStream(
      path,
      FileMode.Open,
      FileAccess.ReadWrite
    );

    BinaryReader reader = new BinaryReader(file);
    BinaryWriter writer = new BinaryWriter(file);

    try {
      if (file.Length % Task1.Functions.IntSize != 0) {
        throw new FormatException(
          "Размер файла не кратен " + Task1.Functions.IntSize +
          " байтам, файл не содержит целых чисел типа int."
        );
      }

      int count = (int)(file.Length / Task1.Functions.IntSize);

      // Позиция выбирается от 0 (перед первым числом)
      // до count (после последнего числа).
      int index = Random.Next(0, count + 1);
      long offset = (long)index * Task1.Functions.IntSize;

      // Методом Seek() переходим к позиции вставки
      // и запоминаем все байты, которые идут после неё.
      file.Seek(offset, SeekOrigin.Begin);
      byte[] tail = reader.ReadBytes((int)(file.Length - offset));

      // Возвращаемся к позиции вставки, записываем новое число,
      // а за ним - сохранённый остаток файла.
      file.Seek(offset, SeekOrigin.Begin);
      writer.Write(number);
      writer.Write(tail);
      writer.Flush();

      return index;
    }
    finally {
      writer.Close();
    }
  }
}
}
