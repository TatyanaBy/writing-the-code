// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5; 782 -> 8; 918 -> 1


// 1 вариант
// Console.Write("Введите трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(threeDigitNumber);
// int secondNumber = threeDigitNumber % 100 / 10;
// Console.WriteLine("Вторая цифра числа: ");
// Console.Write(secondNumber);


// 2 вариант
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindSecondDigit(number);
int FindSecondDigit(int number)
{
    int result = number % 100 / 10;
    return result;
 }
 if (number < 1000 && number > 99)
{
 Console.WriteLine("Вторая цифра числа: ");
 Console.Write(result);
}
 else
 {
    Console.WriteLine("Не является трехзначным числом");
 }



