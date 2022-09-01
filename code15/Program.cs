// в этой папке все задачи с семинара 4.

// Демонстрационная задача. Напишите программу, которая на вход принимает число А и выдает сумму чисел от 1 до А

// bool isNumber = int.TryParse(Console.ReadLine(), out int number);  //1.принимаем число
// if (isNumber == false) // 5.завалидируем (если ввели не число, а например какой-то символ и т.д.)
// {
//     Console.WriteLine("Это не число");
//     return;
// }

// int result = GetSumNumber(number); // 3.говорим что результат от метода будет результатом...
// Console.WriteLine(result); // 4. выводим результат


// int GetSumNumber(int number) //2.вводим метод
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
// sum = sum + i;
//     }
//     return sum;
// }

// задача 26. напишите программу, которая на вход принимает число и на выходе выдает количество цифр в числе.

// bool isNumber = int.TryParse(Console.ReadLine(), out int number);  //1.принимаем число
// if (isNumber == false) // 5.завалидируем (если ввели не число, а например какой-то символ и т.д.)
// {
//     Console.WriteLine("Это не число");
//     return;
// }

// int result = GetQuantityNumber(number); // 3.говорим что результат от метода будет результатом...
// Console.WriteLine(result); // 4. выводим результат


// int GetQuantityNumber(int number) //2.вводим метод
// {
//     int quantity = 0; //счетчик
//     while (number > 0)
//      {
//       quantity++;
//       number = number / 10;
//     }
//     return quantity;
// }

// Задача 28. напишите программу, которая на вход принимает число n и на выходе выдает произведение чисел от 1 до n.
// bool isNumber = int.TryParse(Console.ReadLine(), out int number);  //1.принимаем число
// if (isNumber == false) // 5.завалидируем (если ввели не число, а например какой-то символ и т.д.)
// {
//     Console.WriteLine("Это не число");
//     return;
// }

// int result = GetPrNumber(number); // 3.говорим что результат от метода будет результатом...
// Console.WriteLine(result); // 4. выводим результат


// int GetPrNumber(int number) //2.вводим метод
// {
//     if (number < 1)
//     {
//         return 0;
//     }
//     int result = 1; //счетчик
//     for (int i = 1; i <= number; i++)
//      {
      
//       result = result * i;
//     }
//     return result;
// }

//Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// int[] FillArray (int n)
// {
//     Random random = new Random();
//     int[] newArray = new int [n];
//     for (int i = 0; i < n; i++)
//     {
//         newArray[1] = random.Next(0,2);
//     }
// return newArray;
// }
// void PrintArr(int[] array)
// {for(int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine($" {array[i]}");
// }
// }

// bool isNumber = int.TryParse(Console.ReadLine(), out int number);  //1.принимаем число
// if (isNumber == false) // 5.завалидируем (если ввели не число, а например какой-то символ и т.д.)
// {
// Console.WriteLine("Это не число");
// return;
// }
// PrintArr(FillArray(number)); 
