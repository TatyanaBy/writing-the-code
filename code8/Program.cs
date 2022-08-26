// задача 12. Напишите программу, которая на вход будет принимать два числа и выводить. является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программы выводит остаток от деления

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = a % b;
if (result == 0)
{
Console.Write("Кратно");
}
else
{
int ostatok = a % b;
Console.Write(ostatok);
}
