// Напишите программу, которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N
//Пример. 4 - -4,-3,-2,-1,0,1,2,3,4

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int negnum = num * -1;
while (negnum <= num)
{
    Console.Write(negnum);
    negnum++;
}
