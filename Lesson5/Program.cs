// Решаем демонстрационную задачу на семинаре 5
// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и 
//положительных элементов массива.


#nullable disable
//Задайте массив из 12 элементов, заполненный случайными числами из
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Console.WriteLine("Enter length - ");



// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[] array = FillArray(length);
// PrintArray(array);

// int sumPositiveNumber = GetSumPositiveNumberInArray(array);

// Console.WriteLine($"sum Positive Number - {sumPositiveNumber}");

// int sumNegativeNumber = GetSumNegativeNumberInArray(array);

// Console.WriteLine($"sum negative Number - {sumNegativeNumber}");

// int GetSumNegativeNumberInArray(int[] array)
// {
//     int sumNegativeNumber = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             sumNegativeNumber += array[i];
//         }
//     }

//     return sumNegativeNumber;
// }



// int GetSumPositiveNumberInArray(int[] array)
// {
//     int sumPositiveNumber = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0)
//         {
//          sumPositiveNumber += array[i];
//         }
//     }

//     return sumPositiveNumber;
// }





// void PrintArray(int[] array)
// {
//     if(array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
    
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-9, 10);
//     }
//     return array;
// }


// Задача 32. НЕ РАБОТАЕТ. НУЖНО НАЙТИ РЕШЕНИЕ.
//Напишите программу замены элементов массива: положит.элементы заменить на отрицат и наоборот
//например, [-4,-8,8,2] \ [4,8,-8,-2]
#nullable disable
// Console.WriteLine("Enter length - ");

// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[] array = FillArray(length);
// PrintArray(array);
// int[] revArray = PrintArrayOtr(array);
// PrintArray(revArray);


// void PrintArray(int[] array)
// {
//     if(array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }

// int PrintArrayOtr(int[] array)
// {
//     if(array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//     }

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * -1;
//     }
//     return array;
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
    
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-10, 11);
//     }
//     return array;
// }


// задача 33. Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве.
// проверка вводимого числа
// Console.Write("введите длину массива ");
// bool isNumber_x = int.TryParse(Console.ReadLine(), out int x);  //.принимаем число
// if (isNumber_x == false) // завалидируем (если ввели не число, а например какой-то символ и т.д.)
// {
// Console.WriteLine("Это не число");
// return;
// }

// int[] array = GetArray(x);

// Console.Write("введите значение ");
// bool isNumber_y = int.TryParse(Console.ReadLine(), out int y);

// Console.WriteLine(Contains(array,y));
// //заполняем массив
// int[] GetArray(int length)
// {
//     int[] array = new int [length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"введите {i} элемент массива: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// //Ищем число в массиве

// bool Contains(int[] array, int a)
// {
//     for (int i = 0; i < array.Length; i++)
// {
//         if(array[i] == a) 
//         {
//             return true;
//         }
// }
//             return false;
// }


