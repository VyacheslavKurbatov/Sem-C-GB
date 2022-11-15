// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2 - b1)/(k1 - k2)
// y = k1*x + b1, 
// y = k2*x + b2
// y = (k2*b1 - k1*b2)/(k2-k1)

Console.WriteLine("Программа находит точку пересечения двух прямых, заданных уравнениями y = k1*x + b1, y = k2*x + b2");
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// Решение через массив

// double[] arrayXY = FindXY(b1,k1,b2,k2);
// PrintArray(arrayXY);

// double[] FindXY(double b1, double k1, double b2, double k2)
// {
//     double[] arrayXY = new double[2];
//     arrayXY[0] = (b2 - b1)/(k1 - k2);
//     arrayXY[1] = (k2*b1 - k1*b2)/(k2-k1);
//     return arrayXY;
// }
// void PrintArray(double[] array)
// {
//     Console.Write("(");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]},");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine(")");
// }

double x = FindX(b1,k1,b2,k2);
double y = FindY(b1,k1,b2,k2);

Console.WriteLine($"-> ({x} ; {y})");

// if(y == k1*x + b1 && y == k2*x + b2) Console.WriteLine($"-> ({x} ; {y})"); // проверка 
// else Console.WriteLine("Иди учи математику");

double FindX(double b1, double k1, double b2, double k2)
{   
    double x = (b2 - b1)/(k1 - k2);
    x = Math.Round(x, 2, MidpointRounding.ToZero);
    return x;
}

double FindY(double b1, double k1, double b2, double k2)
{   
    double y = (k2*b1 - k1*b2)/(k2-k1);
    y = Math.Round(y, 2, MidpointRounding.ToZero);
    return y;
}