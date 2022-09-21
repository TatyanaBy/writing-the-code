// ДЗ 9,через рекурсию.  

//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

void Recursive(int m, int n, int i = 0)
{
    if(i == n)
    {
        return;
    }
    Console.WriteLine(m);
    Recursive(++m, n, ++i);
}
Recursive(1,5);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 4; N = 8. -> 30
// M = 1; N = 15 -> 120

bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (isNumberM || isNumberN)
{
    System.Console.WriteLine(GetSumNumber(m, n));
}
else
{
    Console.WriteLine("это не число");
    return;
}

int GetSumNumber(int m, int n)
{
    int sum = m;
    {
    if (m == n)
    {
        return 0;
    }
    else
    {
        m++;
        return sum = m + 1 + GetSumNumber(m, n);
    }
    }
}

Recursive (m, n);

void Recursive(int m, int n)
{
    Console.Write(GetSumNumber(m - 1, n));
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m < 0 || n < 0)
{
    Console.WriteLine("Введены отрицательные числа");
    return;
}

// PrintFunction(m,n);

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
}

void PrintFunction(int m, int n)
{
    Console.WriteLine(FunctionAkkerman(m, n)); 
}

PrintFunction(m,n);