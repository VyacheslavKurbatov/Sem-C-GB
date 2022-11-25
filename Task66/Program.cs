// Задача 66: Задайте значения M и N. Напишите программу, которая 
// 1. найдёт сумму натуральных элементов в промежутке от M до N. 
// 2. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Программа сумму натуральных элементов в промежутке от M до N.");

int n = InputNumber("Введите число N: ");
int m = InputNumber("Введите число M: ");

Console.Write($"M = {m}; N = {n} -> ");

if (n > m)
{
    int temp = m;
    m = n;
    n = temp;
}

int sum = SumNamberBetweenNM(n, m);
Console.WriteLine($"{sum}");

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

int SumNamberBetweenNM(int numN, int numM)
{
    if (numN == numM) return numN;
    return numN + SumNamberBetweenNM(numN + 1, numM);
}