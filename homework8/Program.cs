// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);


if (isNumberN != true)
{
Console.WriteLine("Не число");
return;
}
PrintArray (GetArray(N));
int[] GetArray (int n)
{
    int i = 1;
    int[] result = new int[n];
    while(i <= n)
    {
        result[i-1] = (int) Math.Pow (i,3);
        i++;
    }
    return result;
}
void PrintArray(int[] Array )
{
    int i = 0;
    int len = Array.Length;
     while(i < len)
     {
        Console.WriteLine(Array[i]);
        i++;
     }
}

