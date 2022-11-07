// задача 19 разбор
// int num = 12345;

// if (num >= 10000 && num <= 99999)
// {
//     int num1 = num / 10000;
//     int num2 = num / 1000 % 10;
//     int num4 = num / 10 % 10;
//     int num5 = num % 10;

//     if (num1 == num5 && num2 == num4) Console.WriteLine("Да");
//     else Console.WriteLine("Нет");
// }

// else Console.WriteLine("Введено не пятизначное число");


// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default;
    for (int i = 0; i <= number; i++)
    {
        sum = sum + i; // sum += i можно так записать 
    }
    return sum;
}

int sumNumbers = SumNumbers(num);

Console.WriteLine($"{num} -> {sumNumbers}");