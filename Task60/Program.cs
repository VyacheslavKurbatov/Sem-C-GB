// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Программа аполняет кубическую матрицу неповторяющимися двузначными числами и печатает ее в консоли");

// Ввод и проверка данных

Console.Write("Задайте кол-во строк матрицы: ");
var enterDataRows = Console.ReadLine();

int newRows = NewSizeArray(size: enterDataRows, // Проверяем, является ли положительным числом введенные данные.
                            text: "Задайте кол-во строк матрицы: "
                           );

Console.Write("Задайте кол-во столбцов матрицы: ");
var enterDataColums = Console.ReadLine();

int newColums = NewSizeArray(size: enterDataColums,   // Проверяем, является ли положительным числом введенные данные.
                              text: "Задайте кол-во столбцов матрицы: "
                             );

Console.Write("Задайте глубину матрицы: ");
var enterDataDepth = Console.ReadLine();

int newDepth = NewSizeArray(size: enterDataDepth,   // Проверяем, является ли положительным числом введенные данные.
                              text: "Задайте глубину матрицы: "
                             );

Console.WriteLine();

//Программа

int[,,] cubicArray = CreateCubicArrayUniqueRndInt(newRows, newColums, newDepth, 10, 99);
// PrintCubicMatrix(cubicArray); // для проверки

Console.WriteLine();
int[] newArray = NewArray(cubicArray);
// PrintArray(newArray); // для проверки

Console.WriteLine();
ChangeArray(newArray, 10, 99);
// PrintArray(newArray); // для проверки

Console.WriteLine();
FillCubicArray(newArray, cubicArray);
PrintCubicMatrix(cubicArray);

//Функции

int[,,] CreateCubicArrayUniqueRndInt(int rows, int columns, int depth, int min, int max) // Создает кубическую матрицу
{
    int[,,] cubicArray = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < cubicArray.GetLength(0); i++)
    {
        for (int j = 0; j < cubicArray.GetLength(1); j++)
        {
            for (int k = 0; k < cubicArray.GetLength(2); k++)
            {
                // cubicArray[i, j, k] = min++; // еще один вариант заполнения неповторяющиимися двузначными числами
                cubicArray[i, j, k] = rnd.Next(min, max + 1);
            }

        }
    }
    return cubicArray;
}

void PrintCubicMatrix(int[,,] cubicArray)  // Печатает кубическую матрицу в консоли
{

    for (int k = 0; k < cubicArray.GetLength(2); k++)
    {
        Console.WriteLine($"Слой {k}");
        for (int i = 0; i < cubicArray.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < cubicArray.GetLength(1); j++)
            {
                if (j < cubicArray.GetLength(1) - 1) Console.Write($"{cubicArray[i, j, k],3} ({i},{j},{k}) |");
                else Console.Write($"{cubicArray[i, j, k],3} ({i},{j},{k})");
            }
            Console.WriteLine(" |");
        }
        Console.WriteLine();
    }
}

int[] NewArray(int[,,] cubicArray)
{
    int count = 0;
    int[] array = new int[cubicArray.Length];
    for (int i = 0; i < cubicArray.GetLength(0); i++)
    {
        for (int j = 0; j < cubicArray.GetLength(1); j++)
        {
            for (int k = 0; k < cubicArray.GetLength(2); k++)
            {
                array[count] = cubicArray[i, j, k];
                count++;
            }
        }
    }
    return array;
}

void PrintArray(int[] array) // Печатает одномерный массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void ChangeArray(int[] array, int min, int max) // проверяет и заменяет одинаковые значения в массиве
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length-2; i++)
    {
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if (array[i] == array[j])
            {
                array[j] = rnd.Next(min, max + 1);
                while (array[i] == array[j])
                {
                    array[j] = rnd.Next(min, max + 1);
                }
            }
        }
    }
}

void FillCubicArray(int[] array, int[,,] cubicArray) // заполняет куб новыми значниями
{
    int count = 0;
    for (int i = 0; i < cubicArray.GetLength(0); i++)
    {
        for (int j = 0; j < cubicArray.GetLength(1); j++)
        {
            for (int k = 0; k < cubicArray.GetLength(2); k++)
            {
                cubicArray[i, j, k] = array[count++];
            }

        }
    }
}

bool CheckingEnteredData(int number)    // Проверяет больше или меньше 0
{
    if (number > 0) return true;
    else return false;
}

int NewSizeArray(string size, string text) // Проверяет больше или меньше 0, если меньше просит ввести данные снова
{
    int newSize = IsNumeric(size);
    while (CheckingEnteredData(newSize) == false)
    {
        Console.WriteLine("Размер массива не может быть текстом, дробью, равен или меньше 0");
        Console.Write($"{text}");
        var enterData = Console.ReadLine();
        newSize = IsNumeric(enterData);
    }
    return newSize;
}

int IsNumeric(string enterData) // Проверяем, является ли натуральным числом введенные данные.
{
    int n;
    bool isNumeric = int.TryParse(enterData, out n);
    return n;
}