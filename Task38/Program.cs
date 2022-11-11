// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Программа считает разницу между максимальным и минимальным элементов массива");
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте минимальное число в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальное число в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

int newSizeArray = NewSizeArray(size);

double[] arr = CreateArrayRndDouble(newSizeArray, min, max);
Console.WriteLine("Исходный массив");
PrintArray(arr);
double maxArray = FindMaxArray(arr);
double minArray = FindMinArray(arr);
double differenceTwoNumbers = DifferenceTwoNumbers(maxArray, minArray);

// Console.WriteLine($"Max = {maxArray}");
// Console.WriteLine($"Min = {minArray}");
Console.WriteLine($"Разница между max и min = {differenceTwoNumbers}");


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)
    {
            double num = array[i] = rnd.NextDouble() * (max - min) + min;
            array[i] = Math.Round(num, 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool CheckingEnteredData(int number)
{
    if (number > 0) return true;
    else return false;
}

int NewSizeArray(int size)
{
    int newSize = default;
    if (size <= 0)
    {
        newSize = size;
        if (CheckingEnteredData(newSize) == false)
        {
            Console.WriteLine("Размер массива не может быть равен или меньше 0");
            Console.Write("Задайте размер массива: ");
            newSize = Convert.ToInt32(Console.ReadLine());

            while (CheckingEnteredData(newSize) == false)
            {
                Console.WriteLine("Размер массива не может быть равен или меньше 0");
                Console.Write("Задайте размер массива: ");
                newSize = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    else newSize = size;
    return newSize;
}

double FindMaxArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double FindMinArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

double DifferenceTwoNumbers(double number1, double number2)
{
    double difference = number1 - number2;
    difference = Math.Round(difference, 2);
    return difference;
}