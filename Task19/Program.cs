// Задача 19. Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Эта программа проверяет является ли число палиндромом");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ReverseNumber(int num)
{
    int res = 0;
    for (int i = 1; num > 0; i++)
    {
        int remnant = num % 10;
        res = res * 10 + remnant;
        num = num / 10;
    }
    return res;
}
int figure = 0;
if(number<0)
{
    figure = Math.Abs(number);
}
else figure = number;
int reverse = ReverseNumber(figure);
if (reverse == figure)
{
    Console.WriteLine($"{number} -> Да ");
}
else Console.WriteLine($"{number} -> Нет ");