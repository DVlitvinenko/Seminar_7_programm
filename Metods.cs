using System.Text;
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}
// 1. Создание массива double

public static double []CreateArrayDouble (int size)
{
  return new double[size];
}

// 2. Заполнение массива рандомно double

public static void FillArray (double []NameArray, int min, int max)
{
  int index = 0;
  while (index < NameArray.Length)
  {
    NameArray[index] = new Random().Next(min, max) + new Random().NextDouble();
    index++;
  }
}

// 2. Заполнение массива рандомно

public static void FillArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
    NameArray[index] = Rundom(-10, 11);
    index++;
  }
}

// 2.1 Заполнение массива с клавиатуры

public static void FillArrayKeyboard (int []NameArray)
{
  for(int index = 0; index < NameArray.Length; index++)
  {
    NameArray[index] = Input($"Введите координату {index+1} точки: ");
  }
}

// 3. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}


// 3.2 ввод данных рандомно

public static int Rundom (int min, int max)
{
  int result = 0;
  result = new Random().Next(min, max);
  return result;
}

// 4. перемешивание массива

public static void MixArray (int[] NameArray)
{
  int index = 0;
  int temp = 0;
  int MixIndex = 0;
  int length = NameArray.Length;
  while (index < length-index)
  {
    MixIndex = new Random().Next(index+1, length);
    temp = NameArray[index];
    NameArray[index] = NameArray[MixIndex];
    NameArray[MixIndex] = temp;
    index++;
  }
}

// 5. Вывод массива

public static void WriteArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}

// Вывод массива в строку stringBuilder

public static void WriteArrayInStringBuilder (int []NameArray)
{
    StringBuilder text = new();
    int index = 0;
    while (index < NameArray.Length)
    {
      text.Append(NameArray[index] + " ");
      index++;
    }
  System.Console.WriteLine(text);
}

// запись массива в файл

public static void ArrayToFile(string fileName, int []NameArray)
{
  StringBuilder text = new();
  for(int i = 0; i < NameArray.Length; i++)
  {
    text.Append(NameArray[i] + " ");
  }
  File.WriteAllText(fileName, text.ToString());
  Console.WriteLine("Запись в файл" + fileName + "успешно завершена.");
}


//Сравнение числа

public static int CompNumber (int num1, int num2)
{
  if(num1 == num2)
  return 1;
  else
  return 0;
}

//нахождение суммы одиноковых чилес

public static int FindNumber (int []array, int numb)
{
  int index = 0;
  int summ = 0;
  while (index < array.Length)
  {
    if(numb == array[index])
    summ = summ + 1;
    index++;
  }
  return summ;
}

//поиск и замена одинаковых+-

public static void FindNumberInArrayAndReplase(int [] array)
{
  int temp = 0;
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = 0; j < array.Length; j++)
    {
      if (array[j] == -array[i])
      {
        temp = array[j];
        array[j] = array[i];
        array[i] = temp;
      }
    }
  }

}

//проверка на повтор числа

public static int ProvNaPovtor(int []array, int numb)
{
  int index = 0;
  while (index < numb)
  {
    if(array[numb] == array[index])
    {
      return 1;
    }
    index++;
  }
  return 0;
}

//перебор массива со счетом колличества повторяющихся элементов

public static void Enumepatian (int[] array)
{
  int index = 0;
  while (index < array.Length)
  { 
    if (ProvNaPovtor(array, index) == 0)
    {
    Console.Write(array[index] + "");
    Console.Write("-" + FindNumber(array, array[index])+",");
    }
    index++;
  }
}

// Проверка является ли число пятизначным

public static int ProvNaFifth ()
{
  int number = Input("Введите 5-тизначное число: ");
  while (number < 9999 || number > 100000)
  {
    Console.WriteLine("Число не пятизначное!");
    number = Input("Введите 5-тизначное число");
  }
  return number;
}

//Проверка на палиндром пятизначного числа
public static void Palindrom5th (int number1)
{
  int number2 = (number1 / 10000 - number1 % 10) + (number1 % 10000 / 1000 - number1 % 100 / 10);
  if (number2 == 0) 
  Console.WriteLine("Палиндром");
  else 
  Console.WriteLine("Не палиндром");
}

// Расстояние между двумя точками по трем координатам
//  Формула: l = √ (x 2 - x 1)^2+ (y 2 - y 1)^2+ (z 2 - z 1)^2
// Math.Sqrt() - метод сишарп кеоторый выводит квадратный корень

public static double LengthBetwinPoints(int []array1, int[] array2)
{
  int length = 0;
  for(int i = 0; i < array1.Length; i++)
  {
    length = length + (array1[i] - array2[i])*(array1[i] - array2[i]);
  }
  double lengthBetwin = Convert.ToDouble(Math.Sqrt(length));
  return lengthBetwin;
}


//получаем таблицу кубов до max
public static void ThreeCubed (int max)
{
  Console.Write(max + " -> 1");
  for (int i = 2; i <= max; i++)
  {
    Console.Write(", " + i*i*i);
  }
}

  // возведение number1 в степень number2
public static int AupToB(int a, int b)
{
  int result = a;
  for (int i = 2; i <= b; i++)
  {
    result = result * a;
  }
  return result;
}
// сумма цифр в числе

public static int SummInNumber (int number)
{
  int summ = 0;
  while (number > 0)
{
  summ = summ + (number % 10);
  number = number / 10;
}
  return summ;
}

// подсчет и вывод четных чисел в массиве
public static void SummNumberInArray (int [] Array)
{
  int summ = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] % 2 == 0)
    {
      summ = summ + 1;
    }
  }
  Console.WriteLine();
  Console.WriteLine(summ);
}
// подсчет и вывод стоящих на нечётных позициях.
public static void SummNumberNechotPosInArray (int [] Array)
{
  int summ = 0;
  for (int i = 1; i < Array.Length; i=i+2)
  {
    summ = summ + Array[i];
  }
  Console.WriteLine();
  Console.WriteLine(summ);
}
// 4. Вывод массива double

public static void WriteArray (double []NameArray)
{
  int index = 0;
  while (index < NameArray.Length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}
  // Нахождение максимального элемента double

  public static double MaxInArray(double[] NameArray)
  {
    double max = NameArray[0];
    for (int i = 0; i < NameArray.Length; i++)
    {
      if (max < NameArray[i]) max = NameArray[i];
    }
    return max;
  }

  // Нахождение минимального элемента double

  public static double MinInArray(double[] NameArray)
  {
    double min = NameArray[0];
    for (int i = 0; i < NameArray.Length; i++)
    {
      if (min > NameArray[i]) min = NameArray[i];
    }
    return min;
  }

// вывод разницы между максимальным и минимапльным элементом

public static void PrintMaxMinusMin(double max, double min)
{
  double result = max - min;
  Console.WriteLine(result);
}

//Суммирование количества чисел больше 0 и вывод
public static void SummPositivNumbers(int []Array)
{
  int summ = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] > 0) summ += 1;
  }
  Console.WriteLine("Количество чисел больше нуля: " + summ);
}

//решение системы уравнений. y и x и будут координатами точки пересечения.
// y = k1 * x + b1, y = k2 * x + b2; 
public static void PointOnTwoLine(double k1, double b1, double k2, double b2)
{
  double x = (b1-b2)/(k2-k1);
  double y = k2 * x + b2;
  Console.WriteLine($"{x}, {y}");
}
}


 

 
