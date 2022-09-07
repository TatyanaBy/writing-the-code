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
        quantityNumbers++; //+= array[i];
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