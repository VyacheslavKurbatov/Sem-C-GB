// Задача 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// if(number2*number2 == number1 || number1*number1 == number2)
// {
//     Console.WriteLine($"{number1}, {number2} -> да");
// }
// else Console.WriteLine($"{number1}, {number2} -> нет");


bool Square(int num1,int num2)
{
    if(num2*num2 == num1 || num1*num1 == num2) return true;
    return false; // можно без else
}

if(Square(number1, number2))
{
    Console.WriteLine($"{number1}, {number2} -> да");
}
else Console.WriteLine($"{number1}, {number2} -> нет");