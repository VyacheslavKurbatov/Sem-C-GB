// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Программа заполняет матрицу спирально");

// Ввод и проверка данных
Console.WriteLine("Кол-во строк матрицы должно быть равно кол-ву столбцов.");
Console.Write("Задайте размер матрицы: ");
var enterDataRowsColums = Console.ReadLine();
int newRowsColums = NewSizeArray(size: enterDataRowsColums, // Проверяем, является ли положительным числом введенные данные.
                                 text: "Задайте кол-во строк матрицы: "
                                );

//Программа

int[,] matrix = CreateMatrixInt(newRowsColums, newRowsColums);
FillMatrix(matrix);
PrintMatrix(matrix);

// Методы

int[,] CreateMatrixInt(int rows, int colums) //создает и заполняет матрицу случайными числами
{
    int[,] matrix = new int[rows, colums];
    return matrix;
}

void FillMatrix(int[,] matrix)  // Заполняет матрицу по спирали
{
    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= matrix.Length)
    {
        matrix[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
        else i--;
    }
}

void PrintMatrix(int[,] matrix) // Печатает матрицу в консоли
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