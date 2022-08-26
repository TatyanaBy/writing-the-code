// задача 16. Напишите программу, которая на вход принимает два числа и проверяет является ли одно число квадратом другого
// 5,25-> да и т.д.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a )
{
    Console.Write("Является");
}
else
{
Console.Write("не является");
}
