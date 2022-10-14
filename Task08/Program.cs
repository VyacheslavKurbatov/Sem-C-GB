// Напишите программу, которая 
// 1.на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа показывает все четные числа от 1 до введенного числа");

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = 1;

    Console.Write($"{number} -> ");
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count} ");
        }
        count = count + 1;
    }
}
else Console.Write("Введите целое положительное число: ");