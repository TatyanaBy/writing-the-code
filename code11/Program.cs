// Напишите программу, которая принимает на вход координаты точки (Х и Y), причем Х не равно 0 и Y не равно 0 и выдает номер четверти плоскости, 
//в которой находится эта точка
// x>0 & y>0 = 1
// y>0 & x<0 = 2
// x<0 & y<0 = 3
// x>0 & y<0 = 4

Console.WriteLine("Введите x");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите y");
bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

if (isNumberX != true || isNumberY != true)
{
Console.WriteLine("Числа введены не верно.");
return;
}

// метод, который завалидирует..
bool Validate(int x, int y)
{
    if(x == 0 || y == 0)
    {
        return false;
    }
    return true;
}
bool isValid = Validate(x, y);
if (isValid == false)
{
Console.WriteLine("Число равно нулю?");
return;
}

int result = GetPosition(x, y);
Console.WriteLine(result);

int GetPosition(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }
    if(y > 0 && x < 0)
    {
        return 2;
    }
    if(x < 0 && y < 0)
    {
        return 3;
    }
    if(x > 0 && y < 0)
    {
        return 4;
    }
return -1;
}