// Задача 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int FirstAndThirdDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return (firstDigit * 10) + thirdDigit;
}

int ftnumber = FirstAndThirdDigit(number);
Console.Write($"Первая и третья цифра числа {number} -> {ftnumber}");