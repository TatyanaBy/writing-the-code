// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//А(3,6); В(2,1) -> 5,09

Console.Write("Введите координату X первой точки: ");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);

Console.Write("Введите координату Y первой точки: ");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);

Console.Write("Введите координату X второй точки: ");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);

Console.Write("Введите координату Y второй точки: ");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);

if (!isNumberX_1 || !isNumberY_1 || !isNumberX_2 || !isNumberY_2)
{
Console.WriteLine("Числа введены не верно.");
return;
}
Console.Write($"Расстояние: {GetLenght(x1,y1,x2,y2)}");

double GetLenght(int x1, int y1, int x2, int y2)
{
return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}
