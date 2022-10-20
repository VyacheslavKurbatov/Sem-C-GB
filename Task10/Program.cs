// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Эта программа показывает вторую цифру числа.");

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int secondDigit = num % 100;
    return secondDigit / 10;
}

if (number > 99 && number < 1000)
{
    Console.Write($"Вторая цифра числа {number} -> {SecondDigit(number)}");
}
else Console.Write("Вы ввели не трехзачное числою.");