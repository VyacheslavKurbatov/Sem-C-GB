// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Программа находит строку с наименьшей суммой элементов");

// Ввод и проверка данных
Console.WriteLine("Задайте прямоугольный массив");
Console.Write("Задайте кол-во строк массива: ");
var enterDataRows = Console.ReadLine();

int newRows = NewSizeArray(size: enterDataRows, // Проверяем, является ли положительным числом введенные данные.
                            text: "Задайте кол-во строк массива: "
                          );

Console.Write("Задайте кол-во столбцов массива: ");
var enterDataColums = Console.ReadLine();

int newColums = NewSizeArray(size: enterDataColums,   // Проверяем, является ли положительным числом введенные данные.
                                text: "Задайте кол-во столбцов массива: "
                            );

while(CheckRowsAndColums(newRows, newColums) == false)
{
    Console.WriteLine("В прямоугольном массиве колличество строк равно колличеству стольбцов");
    Console.Write("Задайте кол-во строк массива: ");
    enterDataRows = Console.ReadLine();

    newRows = NewSizeArray(size: enterDataRows, // Проверяем, является ли положительным числом введенные данные.
                                text: "Задайте кол-во строк массива: "
                              );

    Console.Write("Задайте кол-во столбцов массива: ");
    enterDataColums = Console.ReadLine();

    newColums = NewSizeArray(size: enterDataColums,   // Проверяем, является ли положительным числом введенные данные.
                                    text: "Задайте кол-во столбцов массива: "
                                );

}

//Программа

int[,] matrix = CreateMatrixRndInt(newRows, newColums, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();

int[] arraySumOnRow = FindSumOnRow(matrix);
PrintArray(arraySumOnRow); // Для проверки
Console.WriteLine();

int maxRow = FindMaxOnArray(arraySumOnRow);
Console.Write($"Индекс строки с максимальной суммой элементов = {maxRow}");

//Функции

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) //создает и заполняет матрицу случайными числами
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  // Печатает матрицу в консоли
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
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

int[] FindSumOnRow(int[,] matrix) // Считает сумму елементов строки.
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void PrintArray(int[] array) // Печатает одномерный массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"|{array[i]}|");
    }
}

int FindMaxOnArray(int[] array) // Находит максимум в массиве
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

bool CheckRowsAndColums(int rows, int colums)
{
    return rows == colums ? true : false;
}