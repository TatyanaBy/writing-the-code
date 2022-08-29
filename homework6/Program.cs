// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5, 78 -> третьей цифры нет. 32679 -> 6


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = FindThreeNumber(number);
// int FindThreeNumber(int number)
// {
//     int result = number % 10;
//     return result;
// }
// if (number > 99)
// {
//  Console.WriteLine("Третья цифра числа: ");
//  Console.Write(result);
// }
// else
// {
//     Console.WriteLine("Нет третьей цифры");
// }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("Третья цифра числа: ");
  Console.Write(numberText[2]);
}
else 
{
  Console.WriteLine("Нет третьей цифры");
}

