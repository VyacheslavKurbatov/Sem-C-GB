// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа выдает является ли число чётным");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.Write($"{number} -> да");
}
else
{
    Console.Write($"{number} -> нет");
}