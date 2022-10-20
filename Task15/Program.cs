// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Эта программа показывает является ли этот день выходным.");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 && number > 0)
{
    bool Weekend(int num)
    {
        if (num == 6 || num == 7) return true;
    return false;
    }
    if (Weekend(number))
    {
        Console.WriteLine($"{number} -> да");
    }
    else Console.WriteLine($"{number} -> нет");
}
else Console.WriteLine("Не день недели");