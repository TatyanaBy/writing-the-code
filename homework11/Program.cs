// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите первое число ");// 1. вводим два числа
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

int GetDegreeNumber(int a) //2.вводим метод
{
    int result = a; 
    for (int i = 1; i < b; i++ )
    {
      result = result * a;
    }
     return result;
}
int result = GetDegreeNumber(a); // 3.говорим что результат от метода будет результатом...
Console.WriteLine($"Первое число в степени второго числа будет равно: {result}"); // 4. выводим результат



