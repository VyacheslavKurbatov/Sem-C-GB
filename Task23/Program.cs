// Задача 23
// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Программа выдает таблицу кубов");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{

    if (num > 0)
    {
        Console.WriteLine($"{num} ->");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i,4} | {i * i * i,4}");
        }
    }
    else
    {
        Console.WriteLine($"введите положительное число");
    }
}

Cube(number);