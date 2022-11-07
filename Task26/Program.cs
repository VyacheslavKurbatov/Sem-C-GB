// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int QuantityNumbers(int number)
// {
//     int count = default;
//     for (int i = 0; number >= 1; i++)
//     {
//         number = number / 10;
//         count = count + 1; 
//     }
//     return count;
// }

int QuantityNumbers(int number)
{
    int i = default;
    for (i = 0; number >= 1; i++)
    {
        number = number / 10; 
    }
    return i;
}

int quantityNumberss = QuantityNumbers(num);
Console.WriteLine($"Колличество чисел {num} -> {quantityNumberss}");