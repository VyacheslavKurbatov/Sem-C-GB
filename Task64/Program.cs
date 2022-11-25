// Задача 64: Задайте значение N. Напишите программу, которая 
// 1.выведет все натуральные числа в промежутке от N до 1. 
// 2.Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Программа выводит все натуральные числа от N до 1");

int n = InputNumber("Введите число N: ");
Console.Write($"N = {n} -> '");
SeriesNaturalNumbers(n);
Console.Write("1'");

// Методы
int InputNumber(string message) // Проверяет введеные данные
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine(), out int value);

        if (!result)
        {
            Console.WriteLine($"Введены некоректные данные. {message} еще раз!");
            Thread.Sleep(1500);
            // Console.Clear();

            continue;
        }

        if (value < 0)
        {
            Console.WriteLine($"Число не может быть отрицательным. {message} еще раз!");
            Thread.Sleep(1500);
            // Console.Clear();

            continue;
        }
        return value;
    }
}

void SeriesNaturalNumbers(int number)
{
    if (number == 1) return;
    Console.Write($"{number}, ");
    SeriesNaturalNumbers(number - 1);
}