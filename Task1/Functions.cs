using System;
using System.Collections.Generic;
using System.IO;

namespace Task1 {
public static class Functions {
  // Размер одного числа типа int в двоичном файле (байт).
  public const int IntSize = sizeof(int);

  private static readonly Random Random = new Random();

  // Генерирует массив из count случайных целых чисел
  // в диапазоне от min до max включительно.
  public static int[] GenerateNumbers(int count, int min, int max) {
    int[] numbers = new int[count];

    for (int i = 0; i < count; i++) {
      numbers[i] = Random.Next(min, max + 1);
    }

    return numbers;
  }

  // Создаёт двоичный файл (или перезаписывает существующий)
  // и записывает в него целые числа методом Write() класса BinaryWriter.
  // Каждое число занимает в файле 4 байта.
  public static void CreateFile(string path, int[] numbers) {
    FileStream file = new FileStream(
      path,
      FileMode.Create,
      FileAccess.Write
    );

    BinaryWriter writer = new BinaryWriter(file);

    try {
      foreach (int number in numbers) {
        writer.Write(number);
      }
    }
    finally {
      writer.Close();
    }
  }

  // Считывает из двоичного файла все целые числа
  // методом ReadInt32() класса BinaryReader,
  // пока не достигнут конец потока.
  public static int[] ReadNumbers(string path) {
    FileStream file = new FileStream(
      path,
      FileMode.Open,
      FileAccess.Read
    );

    BinaryReader reader = new BinaryReader(file);
    List<int> numbers = new List<int>();

    try {
      if (file.Length % IntSize != 0) {
        throw new FormatException(
          "Размер файла не кратен " + IntSize +
          " байтам, файл не содержит целых чисел типа int."
        );
      }

      while (reader.BaseStream.Position < reader.BaseStream.Length) {
        numbers.Add(reader.ReadInt32());
      }
    }
    finally {
      reader.Close();
    }

    return numbers.ToArray();
  }

  // Возвращает размер файла в байтах.
  public static long GetFileSize(string path) {
    return new FileInfo(path).Length;
  }

  // Вычисляет произведение чётных чисел массива.
  // В evenCount возвращается количество чётных чисел.
  // При переполнении генерируется OverflowException.
  public static long ProductOfEven(int[] numbers, out int evenCount) {
    long product = 1;
    evenCount = 0;

    foreach (int number in numbers) {
      if (number % 2 == 0) {
        product = checked(product * number);
        evenCount++;
      }
    }

    return product;
  }
}
}
