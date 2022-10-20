// Задача 18: Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quat = Convert.ToInt32(Console.ReadLine());

string Range(int quater)
{
    if (quater == 1) return "x > 0;  y > 0";
    if (quater == 2) return "x < 0;  y > 0";
    if (quater == 3) return "x < 0;  y < 0";
    if (quater == 4) return "x > 0;  y < 0";
    return "некорректные данные";
}
string range = Range(quat);
Console.WriteLine(range);
