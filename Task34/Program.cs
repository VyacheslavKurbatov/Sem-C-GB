// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// 2. которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Программа показывает количество чётных чисел в массиве");
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int newSizeArray = NewSizeArray(size);

int[] arr = CreateArrayRndInt(newSizeArray, 100, 1000);
Console.WriteLine("Исходный массив");
PrintArray(arr);
int quantityEvenNumber = QuantityEvenNumber(arr);
Console.WriteLine($"Количество четных чисел в массиве {quantityEvenNumber}");


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

int QuantityEvenNumber(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
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