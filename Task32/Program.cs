// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write(" Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)  // int[] - тип данных массив
{
    int[] array = new int[size];
    Random rnd = new Random(); // Random тоже тип данных
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1); // rnd. после точки могут быть другие методы (как Math.)
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

int[] InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

int[] arr = CreateArrayRndInt(size, -100, 100);
PrintArray(arr);
int[] inverseArray = InverseArray(arr);
PrintArray(inverseArray);

// Console.Write("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArrayRndInt(size, -100, 100);
// PrintArray(arr, "Исходный массив");
// int[] inverseArray = InverseArray(arr);
// PrintArray(inverseArray, "Инвертированный массив");



// #region Methods
// int[] CreateArrayRndInt(int size, int min, int max)  // int[] - тип данных массив
// {
//     int[] array = new int[size];
//     Random rnd = new Random(); // Random тоже тип данных
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1); // rnd. после точки могут быть другие методы (как Math.)
//     }
//     return array;
// }
// void PrintArray(int[] array, string message)
// {
//     Console.Write($"{message}: [");

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
//         else Console.Write($"{array[i]}, ");
//     }
// }

// int[] InverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * -1;
//     }
//     return array;
// }
// #endregion


