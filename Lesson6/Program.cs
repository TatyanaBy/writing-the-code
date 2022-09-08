// демонстрационная задача 39.
//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на 
//последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] array = new int[] {1,2,3,4,5}; 
// PrintArray(array); // вывод на экран массива
// int [] reverseArray = ReverseArray(array);
// Console.WriteLine();
// PrintArray(reverseArray);// вывод на экран перевернутого массива

// void PrintArray(int[] array)//печать массива array
// {
//     for (int i = 0; i < array.Length; i++)//проходимся по каждому элементу массива array
//     {
//         Console.Write($"{array[i]} ");// консоль выводит массив, обращаясь по индексу.
//     }
// }


// int[] ReverseArray(int[] array)//задаем массив 
// {
//     /* int tmp;     // как менять элементы массива местами.
//     tmp = array[1];
//     array[1] = array[3];
//     array[3] = tmp;
//     */

//     int[] reverseArray = new int[array.Length];// приравниваем к новому с той же длиной. 

//     for (int i = 0; i < array.Length; i++)
//     {
//         reverseArray[i] = array[array.Length - 1 - i];// переворачиваем
//     }

//     return reverseArray;
// }

//вторая задача. Задача 40. Напишите программу, которая на вход принимает три числа и проверяет 
//может ли существовать треугоьник такой длины

// int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB = Convert.ToInt32(Console.ReadLine());
// int numberC = Convert.ToInt32(Console.ReadLine());

// bool resultIsTriengle = IsTriengle(numberA, numberB, numberC);

//     if(resultIsTriengle == false)
//     {
//         Console.WriteLine("Неверные параметры");
//     }
//     else
//     {
//         Console.WriteLine("Triengle can to exist");
//     }

// bool IsTriengle (int A, int B, int C)
// {
//     if(A <= 0 || B <= 0 || C <= 0)
//     {
//         return false;
//     }
//     if((A + B) > C && (A + C) > B && (B + C) > A)
//     {
//         return true;
//     }
//         return false;  // Это будет тот случай,  когда длинны сторон неправильные
// }
 
//Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное
//1 вариант
// string str = ConvertNumber(x);
// Console.WriteLine(str);
// string ConvertNumber(int x)
// {
//     string result = "";
//     while(x > 0)
//     {
//         int y = x % 2;
//         result = Convert.ToString(y) + result;
//         x = x / 2;
//     }
//     return result;
// }
//2 вариант
// Console.WriteLine("Введите десятичное число");
// int i = Convert.ToInt32(Console.ReadLine());
// string s = Convert.ToString(i,2);
// Console.WriteLine("В двоичной системе счисления: "+s);

//В C# допускается, чтобы метод вызывал самого себя. Этот процесс называется рекурсией, а метод, вызывающий самого себя, — 
// рекурсивным. Вообще, рекурсия представляет собой процесс, в ходе которого нечто определяет само себя. В этом отношении она чем-то напоминает 
// циклическое определение. 
// Рекурсивный метод отличается главным образом тем, что он содержит оператор, в котором этот метод вызывает самого себя.

// int k = 0;
//     Recursive();
//     Console.WriteLine("Я поймал!!!!");

// void Recursive()
// {
//     Console.WriteLine(k);
//     k++;
//     Recursive();
// }

//фибоначи
// double FibonacciBad(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return FibonacciBad(n-1) + FibonacciBad(n-2);
// }

// double FibonacciR(double[] f, int n)
// {
//     if (n == 1 || n == 2)
//     {
//         return f[n - 1] = 1;
//     }

//     if (f[n - 2] != 0)
//     {
//         if (f[n - 1] != 0)
//         {
//             return f[n - 1] = f[n - 2] + f[n - 3];
//         }

//         return f[n - 1] = FibonacciR(f, n - 1) + f[n - 3];
//     }

//     return f[n - 1] = FibonacciR(f, n - 1) + FibonacciR(f, n - 2);
// }

// double FibonacciGood(int n)
// {
    
//     double[] f = new double[n];
//     return FibonacciR(f, n);
// }

//задача.
// int countTests = 40;


// DateTime saveTime;

// Console.WriteLine($"Цикл for: ");
// saveTime = DateTime.Now;
// int fibonacci1 = 1;
// int fibonacci2 = 1;
// for (int i = 1; i <= countTests; i++)
// {
//     Console.WriteLine($"f({i}) = {fibonacci2}");
//     int temporary = fibonacci2;
//     fibonacci2 += fibonacci1;
//     fibonacci1 = temporary; 
// }
// Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");


// Console.WriteLine($"FibonacciBad: ");
// saveTime = DateTime.Now;
// for (int i = 0; i <= countTests; i++)
// {

//     Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
// }
// Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");


// Console.WriteLine($"FibonacciGood: ");
// saveTime = DateTime.Now;
// for (int i = 1; i <= countTests; i++)
// {

//     Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
// }
// Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");

