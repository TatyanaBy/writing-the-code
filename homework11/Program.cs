// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// //3, 5 -> 243 (3⁵)
// //2, 4 -> 16
// Console.WriteLine("Введите первое число ");// 1. вводим два числа
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());

// int GetDegreeNumber(int a) //2.вводим метод
// {
//     int result = a; 
//     for (int i = 1; i < b; i++ )
//     {
//       result = result * a;
//     }
//      return result;
// }
// int result = GetDegreeNumber(a); // 3.говорим что результат от метода будет результатом...
// Console.WriteLine($"Первое число в степени второго числа будет равно: {result}"); // 4. выводим результат


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// если ввожу трехзначное число и более, то некорректно работает. 
// bool isNumber = int.TryParse(Console.ReadLine(), out int number);  //.принимаем число
// if (isNumber == false) // завалидируем (если ввели не число, а например какой-то символ и т.д.)
// {
// Console.WriteLine("Это не число");
// return;
// }
// int GetSumNumber(int number) //2.вводим метод
// {
//   int n = Convert.ToString(number).Length; // преобразование из числа
//   int result = 0;
//   int i = 0;
// while (i < n)
// {
//       // i++;
//       // n = number / 10;
//       // result = n + (number % 10);
//      i++;
//      result += number % 10;
//      number = number / 10; 
//     }
//     return result;
// }

// int result = GetSumNumber(number); // говорим что результат от метода будет результатом...
// Console.WriteLine($"сумма цифр числа: равна {result}"); //  выводим результат


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


 
  #nullable disable
  Console.WriteLine("Enter length - ");

  bool isNumber = int.TryParse(Console.ReadLine(), out int length);
  if (isNumber == false || length <= 0) // длина массива меньше нуля, то ошибка
  {
    Console.WriteLine("Не валидно");
    throw new Exception("Не валидно"); // = return. (ошибка(исключение), то что ввели неправильное число..и программа не сработает)
  }

  // FillArray(length);// передали в этот метод длину массива
  int[] result = FillArray(length);
  PrintArray(result);

  void PrintArray(int[] array)// в этом методе return не нужен. (не возвращает)// этот метод печатает массив
{
  if(array.Length == 0)
  
  {
    Console.WriteLine("Что-то пошло не так");
    return;
  }

  Console.Write("[");
   for(int i = 0; i < array.Length - 1; i++)
   {
    Console.Write($"{array[i]} ");
     }
    Console.Write(array[array.Length - 1]);
    Console.Write("]"); 
}
  int[] FillArray(int length)// Этот метод заполняет через консоль
  {
    int[] array = new int[length];

    string input = Console.ReadLine();

    string[] inputArray = input.Split(",");

   for(int i = 0; i < inputArray.Length; i++)
   {
    array[i] = Convert.ToInt32(inputArray[i]);
     }
  //  for(int i = 0; i < inputArray.Length; i++)
  //  {
  //   Console.Write($"{inputArray[i]} ");
  //  }
   return array;
  }
  




