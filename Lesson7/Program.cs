//демонстрационная задача, семинар 7. 
//Задача 46. Задайте двумерный массив размером m*n, заполненный случайными целыми числами.
//m=3, n=4. 
//1 4 8 19
//5-2 33 -2
//77 3 8 1

int[,] result = CreateRandomArray(2, 6);
PrintTwoArray(result);


void PrintTwoArray(int[,] array)  //печатаем массив

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


int[,] CreateRandomArray(int m, int n) //создаем рандомный массив, вводим заданные переменные m n
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}
