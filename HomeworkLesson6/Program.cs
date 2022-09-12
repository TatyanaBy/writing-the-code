// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Делать с массивом.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел m: ");
int m = Convert.ToInt32(Console.ReadLine());
if(m < 0)
{
    Console.Write("Введено отрицательное значение. Введите количество чисел ");
    return;
}

int[] arrayNumbers = new int[m];

PrintArray(m);

Console.Write("Количество чисел больше нуля равно: ");
Console.Write(Quantity(arrayNumbers)); 


void PrintArray(int m){
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите {i+1} число: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
}
}

int Quantity(int[] arrayNumbers)
{
  int quantity = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
{
    if(arrayNumbers[i] > 0 ) quantity += 1; 
}
  return quantity;
}  



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1-b2)/(k2-k1);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
