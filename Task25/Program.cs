// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Программа возводит число в степень");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int extent = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num, int ext)
    {
        int exponentiation = 1;
        for (int i = 0; i < ext; i++)
        {
            exponentiation = exponentiation * num;
        }
        return exponentiation;
    }

if (extent > 0)
{
    int exponent = Exponentiation(number, extent);
    Console.WriteLine($"число {number} в степени {extent} -> {exponent}");
}
else Console.WriteLine("Введите натуральную степень");