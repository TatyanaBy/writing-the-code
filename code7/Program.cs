// Задача 11. Напишите программу,которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456->46; 782->72;918->98 и т.д.

Random random = new Random();
int randomNumber = random.Next(100,1000);
Console.WriteLine(randomNumber);
int firstNumber = randomNumber / 100;
int secondNumber = randomNumber % 10;
int result = (firstNumber * 10) + secondNumber;

Console.Write(result);



