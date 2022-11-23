// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки двумерного массива");

// Ввод и проверка данных

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

//Программа

int[,] matrix = CreateMatrixRndInt(newRows, newColums, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
MatrixRowSort(matrix);
PrintMatrix(matrix);

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

void MatrixRowSort(int[,] matrix) // Сортирует строки матрицы по возростанию
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}