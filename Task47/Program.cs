// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Программа заполняет заданный массив случайными вещественными числами");

// Ввод и проверка данных

Console.Write("Задайте кол-во строк массива: ");
var enterDataRows = Console.ReadLine();

int rows = IsNumeric(enterDataRows);    // Проверяем, является ли натуральным числом введенные данные.

int newRows = NewSizeArray( size: rows, // Проверяем, является ли положительным числом введенные данные.
                            text: "Задайте кол-во строк массива: "
                          );

Console.Write("Задайте кол-во столбцов массива: ");
var enterDataColums = Console.ReadLine();

int colums = IsNumeric(enterDataColums);        // Проверяем, является ли натуральным числом введенные данные.

int newColums = NewSizeArray(   size: colums,   // Проверяем, является ли положительным числом введенные данные.
                                text: "Задайте кол-во столбцов массива: "
                            );

// Программа

double[,] matrix = CreateMatrixRndDouble(newRows, newColums, -100, 100);
PrintMatrix(matrix);

// Функции

double[,] CreateMatrixRndDouble(int rows, int colums, int min, int max) // Создает и заполняет матрицу случайными числами
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i, j], 3);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)  // Печатает матрицу в консоли
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],10} |");
            else Console.Write($"{matrix[i, j],10}");
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