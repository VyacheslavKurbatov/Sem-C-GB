// Задача 21
// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.
// Пример:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Эта программа вычисляет расстояние между 2мя точками");

Console.Write("Введите координату x1 Точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 Точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1 Точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2 Точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 Точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2 Точки В: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int z11, int x21, int y21, int z21)
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21;
    int rangeZ = z11 - z21;
    double range = Math.Sqrt(rangeX * rangeX + rangeY * rangeY + rangeZ * rangeZ);
    return range;
}

double result = Range(x1,y1,z1,x2,y2,z2);
Console.Write($"А ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");