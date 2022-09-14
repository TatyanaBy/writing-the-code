﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
CreateRandomArray(m, n);
PrintTwoArray(array);

void PrintTwoArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CreateRandomArray(int m, int n)
{
    Random random = new Random();
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(random.Next(-100, 100)) / 10;
            }
        }
        Console.WriteLine();
    }
}



// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];
CreateRandomArray(numbers);
PrintTwoArray(numbers);

void PrintTwoArray(int[,] array)  //печатаем массив

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void CreateRandomArray(int[,] array) //создаем массив
{
    // int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return;
}

Console.Write("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);  //принимаем число
if (isNumber == false) //если ввели не число, а например какой-то символ..)
{
    Console.WriteLine("Это не число");
    return;
}

for (int j = 0; j < numbers.GetLength(1); j++)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        if (number == numbers[i, j])
        {
            Console.WriteLine($"{number} -> {i}, {j}");
        }
    // else
    //     {
    //         Console.WriteLine("Элемента нет"); // так и не разобралась - когда нет элемента, 
    //         //как сделать так, чтобы не выводилась информация по всем индексам, где реально нет элемента...Он по всем бегает и говорит, что здесь нет)
    //     }
    }
}





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
#nullable disable
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
// PrintTwoArray(number);
int[,] number = new int[m, n];
CreateRandomArray(number);
PrintTwoArray(number);

void PrintTwoArray(int[,] array)  //печатаем массив

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
// PrintTwoArray(array);

//int[,] CreateRandomArray(int m, int n) //создаем массив
void CreateRandomArray(int[,] array) //создаем массив
{
    // int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return;
}

for (int j = 0; j < number.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        avarage = avarage + number[i, j]; //складываем элементы
    }
    avarage = avarage / m; //результат делим на количество элементов в столбце m
    Console.Write(avarage + " , ");
}
Console.WriteLine();





