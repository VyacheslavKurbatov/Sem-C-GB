// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа считает сумму цифр в числе");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    num = Math.Abs(num);
    int sum = default;
    for (int i = 0; num > 0 ; i++)
    {
        int x = num % 10;
        num = num / 10;
        sum = sum + x;
    }
    return sum;
}
int sumNumber = SumNumber(number);
Console.Write($"сумма цифр в числе {number} -> {sumNumber}");