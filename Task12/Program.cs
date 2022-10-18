// задача 12. Напишите программу, которая будет 
// 1. принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму. 
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// Пример
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 % number2 == 0)
// {
//     Console.Write($"{number1}, {number2} -> кратно");
// }
// else Console.Write($"{number1}, {number2} -> не кратно, остаток {number1 % number2}");


bool Multiplicity(int num1, int num2)
{
    if(num1 % num2 == 0) return true;
    else return false;
}

if(Multiplicity(number1, number2) == true)
{
    Console.Write($"{number1}, {number2} -> кратно");
}
else Console.Write($"{number1}, {number2} -> не кратно, остаток {number1 % number2}");
