// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Программа находит среднее арифметическое элементов в каждом столбце");

// Ввод и проверка данных

Console.Write("Задайте кол-во строк массива: ");
var enterDataRows = Console.ReadLine();

int rows = IsNumeric(enterDataRows);    // Проверяем, является ли натуральным числом введенные данные.

int newRows = NewSizeArray(size: rows, // Проверяем, является ли положительным числом введенные данные.
                            text: "Задайте кол-во строк массива: "
                          );

Console.Write("Задайте кол-во столбцов массива: ");
var enterDataColums = Console.ReadLine();

int colums = IsNumeric(enterDataColums);        // Проверяем, является ли натуральным числом введенные данные.

int newColums = NewSizeArray(size: colums,   // Проверяем, является ли положительным числом введенные данные.
                                text: "Задайте кол-во столбцов массива: "
                            );

//Программа

int[,] matrix = CreateMatrixRndInt(newRows, newColums, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
double[] arithmeticMeanNumbers = ArithmeticMeanNumbers(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arithmeticMeanNumbers);

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

int NewSizeArray(int size, string text) // Проверяет больше или меньше 0, если меньше просит ввести данные снова
{
    int newSize = size;
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

double[] ArithmeticMeanNumbers(int[,] matrix) //Считает среднее арифметическое элементов в каждом столбце
{
    double[] arithmeticMeanMatrix = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double num = sum / matrix.GetLength(0);
        arithmeticMeanMatrix[j] = Math.Round(num, 2);
    }
    return arithmeticMeanMatrix;
}

void PrintArray(double[] array) // Печатает одномерный массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}