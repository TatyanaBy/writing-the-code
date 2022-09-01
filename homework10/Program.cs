// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет, 12821 -> да, 23432 -> да

// Console.Write("Введите пятизначное число: ");
// string a = Convert.ToString(Console.ReadLine());
// bool GetPalindrome(string[] a)
// {
//       if (a[0]==a[4] || a[1]==a[3])
//       {
//          Console.WriteLine("Это число палиндром.");
//          return result;
//       }

//   else 
//   {
//     Console.WriteLine("Это НЕ палиндром.");
//   }
// }
// bool result = GetPalindrome(a);
// Console.WriteLine(result);

Console.Write("Введите пятизначное число: ");
string? a = Convert.ToString(Console.ReadLine());
bool GetPalindrome(string[] a)
{
bool result = (a[0]==a[4] || a[1]==a[3]);
return result;
}
bool result = GetPalindrome(a);
if (result == true)
{
Console.WriteLine("Это число палиндром.");
}
else
{
Console.WriteLine("Это НЕ палиндром.");
} 




  