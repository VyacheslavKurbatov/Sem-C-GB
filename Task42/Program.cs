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
        if (x == 0) x = 2;
    }

    for (int i = 1; x > 0; i++)
    {
        int remnant = x % 10;
        res = res * 10 + remnant;
        x = x / 10;
    }
    if (res % 10 == 2)
    {
        res /= 10;
        res *= 10;
    }
    return res;
}

int result = ConvertToBinarySystem(number);

Console.WriteLine($"{result}");

// Другое решение (преподавателя)
            // int d10 = 1;
            // int result = 0; // счетчик
            // int number = 46; // число которое переводим
            // int baseNum = 2; // основание системы счесления
            // while (number != 0)
            // {
            //     result = result + number % baseNum * d10;
            //     number = number / baseNum;
            //     d10 = d10 * 10;
            // }
            // Console.WriteLine($"{result}");



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







// int ReverseNumber(int num2)
// {
//     int result = default;

//     while (num2 > 9 || num2 > 0)
//     {
//         result += num2 % 10;
//         result *= 10;
//         num2 /= 10;
//     }
//     result += num2 % 10;

//     return result;
// }

// System.Console.WriteLine("Введите число десятичной системы исчисления");
// int number10 = Convert.ToInt32(Console.ReadLine());

// int ConvertToBin(int num10)
// {
//     int num2 = default;

//     while (num10 > 0)
//     {
//         num2 += num10 % 2;
//         num2 *= 10;
//         num10 /= 2;
//         ConvertToBin(num10);
//     }

//     return num2;
// }

// int number2Rev = ConvertToBin(number10);
// int number2 = ReverseNumber(number2Rev);
// Console.WriteLine(number2);