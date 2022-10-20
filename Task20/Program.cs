// double d = Math.Sqrt(45);
// double res = Math.Round(d, 2, MidpointRounding.ToZero); // округление
// Console.WriteLine(res);

// Math.Sqrt(45); // корень числа

// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int x21, int y21)
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21;
    double rangeZ = Math.Sqrt(rangeX * rangeX + rangeY * rangeY);
    return rangeZ;
}

double result = Range(x1,y1,x2,y2);
Console.Write($"А ({x1},{y1}); B ({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");