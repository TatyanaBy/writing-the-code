// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да, 7 -> да, 1 -> нет

Console.Write("введите номер дня недели ");
int a = Convert.ToInt32(Console.ReadLine());
bool result = GetWeekend(a);
bool GetWeekend(int a)
{
    if (a > 5)
    {
        if (a < 8)
        {
            return true;
        }
    }
return false;
}
Console.WriteLine(result);




