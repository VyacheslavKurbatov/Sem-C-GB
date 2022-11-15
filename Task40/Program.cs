// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три числа через Entre: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

bool IsItTriangle(int num1, int num2, int num3)
{
    return num1<num2+num3 && num2<num1+num3 && num3<num2+num1;
}

bool result = IsItTriangle(number1, number2, number3);
Console.WriteLine(result);