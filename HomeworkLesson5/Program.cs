// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

bool isNumber = int.TryParse(Console.ReadLine(), out int length); //валидация
if (!isNumber || length <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}
int[] array = FillArray(length);
PrintArray(array);
int quantityNumbers = GetNumberOfEvenNumbers(array);
Console.WriteLine($"quantity Numbers - {quantityNumbers}");


int GetNumberOfEvenNumbers(int[] array) //посчитать количество четных в массиве
{
    int quantityNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
        quantityNumbers++;
        }  
    }
    return  quantityNumbers;
}


void PrintArray(int[] array) //вывести массив на печать
{
    if(array.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
int[] FillArray(int length) //задаем массив со случайными трехзначными числами
{
    int[] array = new int[length];
    
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


bool isNumber = int.TryParse(Console.ReadLine(), out int length); //валидация
if (!isNumber || length <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}
int[] array = FillArray(length);
PrintArray(array);
int sumNumbers = GetNumberOddNumbers(array);
Console.WriteLine($"Sum Numbers - {sumNumbers}");


int GetNumberOddNumbers(int[] array) //посчитать сумму нечетных в массиве
{
    int sumNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)
        {
        sumNumbers+= array[i];
        }  
    }
    return sumNumbers;
}

void PrintArray(int[] array) //вывести массив на печать
{
    if(array.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
int[] FillArray(int length) //задаем массив со случайными числами
{
    int[] array = new int[length];
    
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next();
    }
    return array;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//находим макс и мин, после из макс вычитаем мин и получаем разницу. 

int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {3,7,22,200,78,61,5,18,11};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine($"Максимальное число в массиве: {result}");

int Min(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 < result) result = arg2;
    if (arg3 < result) result = arg3;
    return result;
}

int result2 = Min(
    Min(array[0], array[1], array[2]),
    Min(array[3], array[4], array[5]),
    Min(array[6], array[7], array[8])
);
Console.WriteLine($"Минимальное число в массиве: {result2}");

int DifferenceNumbers(int result, int result2)
{
        int differenceMinMax = result - result2;
        return differenceMinMax;
    }

int differenceMinMax = DifferenceNumbers(result, result2);
Console.WriteLine($"Разница между min и max равна: {differenceMinMax}");



