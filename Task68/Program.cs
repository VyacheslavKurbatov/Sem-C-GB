// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Программа вычисляет функцию Аккермана для двух неотрицательных чисел от M до N.");

int n = InputNumber("Введите число N: ");
int m = InputNumber("Введите число M: ");

int akkermanFunction = AkkermanFunction(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {akkermanFunction}");

//Методы
int InputNumber(string message) // Проверяет введеные данные
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine(), out int value);

        if (!result)
        {
            Console.WriteLine($"Введены некоректные данные. {message} еще раз!");
            Thread.Sleep(1500);
            // Console.Clear();

            continue;
        }

        if (value < 0)
        {
            Console.WriteLine($"Число не может быть отрицательным. {message} еще раз!");
            Thread.Sleep(1500);
            // Console.Clear();

            continue;
        }
        return value;
    }
}

int AkkermanFunction(int m, int n) // Функция Аккермана
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}