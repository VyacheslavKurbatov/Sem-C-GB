// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Программа считает сумму элементов массива с нечетными индексами");
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте минимальное число в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальное число в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

int newSizeArray = NewSizeArray(size);

int[] arr = CreateArrayRndInt(newSizeArray, min, max);
Console.WriteLine("Исходный массив");
PrintArray(arr);
int sumNotEvenPosition = SumNotEvenPosition(arr);
Console.WriteLine($"суммуа нечетных элементов массива = {sumNotEvenPosition}");


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
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

int SumNotEvenPosition(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}