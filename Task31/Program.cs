// // Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.
// // 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// // положительных чисел равна 29, сумма отрицательных равна
// // -20.

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

int[] GetSumPosiveNegativElem(int [] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    return new int[]{sumPositive, sumNegative}; // new int[] для сздания нового массива, чтобы не создавать переменную
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPosiveNegativElem = GetSumPosiveNegativElem(arr);
Console.WriteLine($"сумма положительных элементов = {getSumPosiveNegativElem[0]}");
Console.WriteLine($"сумма отрицательных элементов = {getSumPosiveNegativElem[1]}");