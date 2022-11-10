// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] СompositionNum(int[] array)
{
    // int newSize = default;
    // if (array.Length % 2 != 0) newSize = array.Length / 2;
    // else newSize = array.Length / 2 + 1;
    // int[] newArr = { };
    // for (int i = 0; i < array.Length; i++)
    // {
    //     int composition = 0;
    //     composition = array[i] * array[array.Length - i];
    //     newArr[i] = composition;
    //     if (i == newSize) break;
    // }
    // if (array.Length % 2 != 0) newArr[newSize] = array[newSize];
    // return newArr;
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size + 1;
    int[] newArray = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;

}


int[] arr = CreateArrayRndInt(5, -10, 10);
PrintArray(arr);
int[] newArray = СompositionNum(arr);
PrintArray(newArray);