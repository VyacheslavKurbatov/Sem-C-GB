// Напишите программу, которая 
// 1. на вход принимает число 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 конвертирует из типа данных sring в int т.к. Readline по умолчанию считвает как string

// string str = Console.ReadLine();
// int number = Convert.ToInt32 (str);

int suare = number * number;
Console.WriteLine($"Квадрат числа {number} = {suare}");