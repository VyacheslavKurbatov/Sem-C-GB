// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Эта программа показывает третью цифру числа.");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = number;
if (digit > 99 || digit < -99)
{
    if(digit < 0) 
    {
        digit = Math.Abs(digit);
    }
    while (digit > 1000)
    {
        digit = digit / 10;
    }
    digit = digit % 10;
    Console.Write($"Третья цифра числа {number} -> {digit}");
}
else Console.Write("Третьей цифры нет");