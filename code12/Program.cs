// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// 1 вариант:
// Console.WriteLine("Введите номер четверти плоскости ");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

// if (isNumberN != true)
// {
// Console.WriteLine("такой четверти не существует.");
// return;
// }
// string result = GetPosition(N);
// Console.WriteLine(result);

// string GetPosition(int N)
// {
//     if(N == 1)
//     {
//         return "x > 0 && y > 0";
//     }
//      if(N == 2)
//      {
//          return "y > 0 && x < 0";
//      }
//     if(N == 3)
//    {
//     return "x < 0 && y < 0";
//    }
//     if(N == 4)
//    {
//     return "x > 0 && y < 0";
//    }
//    return "координаты не найдены";
//    }
  
//2 вариант:
Console.WriteLine("Введите номер четверти плоскости ");
int NumberN = Convert.ToInt32(Console.ReadLine());
string GetСoordinates(int NumberN)
{
    switch(NumberN)
    {
        case 1: return "x > 0 && y > 0"; 
        case 2: return "y > 0 && x < 0"; 
        case 3: return "x < 0 && y < 0"; 
        case 4: return "x > 0 && y < 0"; 
        default: return "Не найдены координаты"; 
    }
    }
string result = GetСoordinates(NumberN);
Console.WriteLine(result);