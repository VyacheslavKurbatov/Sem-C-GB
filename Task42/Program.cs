// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertToBinarySystem(int num)
{
    int x = default;
    int res = default;
    while (num > 0)
    {
        x = (x * 10) + (num % 2);
        num = (num / 2);
    }

    for (int i = 1; x > 0; i++)
    {
        int remnant = x % 10;
        res = res * 10 + remnant;
        x = x / 10;
    }
    return res;
}

int result = ConvertToBinarySystem(number);

Console.WriteLine($"{result}");

// Решение на семинаре
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int ConvertToBin(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         int dig1 = num % 2;
//         result += dig1;
//         result *= 10;
//         num /= 2;
//     }
//     return result;
// }

// int RevertNumber(int par)
// {
//     int result = 0;
//     while (par > 9)
//     {
//         result += par % 10;
//         result *= 10;
//         par /= 10;
//     }
//     result += par % 10;
//     return result;
// }

// Console.WriteLine(RevertNumber(ConvertToBin(number)));