// Задача 9.Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
// 78 ->8
// 12->2
// 85->8
//всегда где нужно счлучайно - это random. Random random = new Random(); - генерирует случайные числа

Random random = new Random();

int randomNumber = random.Next(10,100);

Console.WriteLine(randomNumber);

int lastNumber = randomNumber % 10;
int firstNumber = randomNumber / 10;

// Console.WriteLine(lastNumber);
// Console.WriteLine(firstNumber);

if (lastNumber > firstNumber)
{ 
    Console.WriteLine("Максимальное число равно " + lastNumber);
}
else
{
    Console.WriteLine("Максимальное число равно " + firstNumber);
}


