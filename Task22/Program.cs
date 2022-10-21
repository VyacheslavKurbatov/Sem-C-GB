// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Square(int num)
// {
//     int count = 1;
//     while(count<=num)
//     {
//         int sqrt = count * count;
//         Console.WriteLine($"_{count}_|_{sqrt}_");
//         count++;
//     }
// }

// Square(number);




Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i,4} | {i*i,4}");
        }
    }
    else 
    {
        Console.WriteLine($"введите значение больше 0");
    }
}

Square(number);