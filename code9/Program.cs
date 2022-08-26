// Задача 14. Напишите программу, которая на вход принимает число и проверяет, кратно ли оно одновременно 7 и 23
// Console.Write("введите число ");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = a / 7;
// Console.WriteLine(result);

// int result2 = a / 23;
// Console.WriteLine(result2);

// int resultOk = result + result2;
// Console.WriteLine(resultOk);


bool CheckNumber(int a)
{
    if (a % 7 == 0)
    {
        if (a % 23 == 0)
        {
            return true;
        }
    }
return false;
}

Console.Write("введите число ");
int a = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumber(a);

Console.WriteLine(result);
