// Напишите программу, которая 
// 1. на вход принимает два числа 
// 2. и выдаёт, какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Эта программа выдает какое из двух чисел больше.");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.Write($"max = {number1}");
}
else
{
    Console.Write($"max = {number2}");
}