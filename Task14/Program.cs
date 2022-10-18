// Задача 14. Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if(number % 7 == 0 && number % 23 == 0)
// {
//     Console.Write($"{number} -> да");
// }
// else Console.Write($"{number} -> нет");

bool Multiple7And23(int num)
{
    if(num % 7 == 0 && num % 23 == 0) return true;
    else return false; // можно без else
}

if(Multiple7And23(number)) Console.Write($"{number} -> да");
else Console.Write($"{number} -> нет");