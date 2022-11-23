// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Программа находит произведение двух матриц");

// Ввод и проверка данных
Console.WriteLine("Задайте Размеры первой матрицы");
Console.Write("Задайте кол-во строк матрицы: ");
var enterDataRows1 = Console.ReadLine();

int newRows1 = NewSizeArray(size: enterDataRows1, // Проверяем, является ли положительным числом введенные данные.
                            text: "Задайте кол-во строк матрицы: "
                           );

Console.Write("Задайте кол-во столбцов матрицы: ");
var enterDataColums1 = Console.ReadLine();

int newColums1 = NewSizeArray(size: enterDataColums1,   // Проверяем, является ли положительным числом введенные данные.
                              text: "Задайте кол-во столбцов матрицы: "
                             );

Console.WriteLine();

Console.WriteLine("Задайте Размеры второой матрицы");
Console.Write("Задайте кол-во строк матрицы: ");
var enterDataRows2 = Console.ReadLine();

int newRows2 = NewSizeArray(size: enterDataRows2, // Проверяем, является ли положительным числом введенные данные.
                            text: "Задайте кол-во строк матрицы: "
                           );

Console.Write("Задайте кол-во столбцов матрицы: ");
var enterDataColums2 = Console.ReadLine();

int newColums2 = NewSizeArray(size: enterDataColums2,   // Проверяем, является ли положительным числом введенные данные.
                              text: "Задайте кол-во столбцов матрицы: "
                             );


//Программа

int[,] matrix1 = CreateMatrixRndInt(newRows1, newColums1, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(newRows2, newColums2, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();

if (CheckRowsAndColums(newRows2, newColums1) == false)
{
    Console.WriteLine("Две матрицы можно перемножить между собой тогда и только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы.");
}
else
{
    int[,] matrixMultiplication = MatrixMultiplication(matrix1, matrix2);
    PrintMatrix(matrixMultiplication);
}

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

bool CheckRowsAndColums(int rows, int colums)
{
    return rows == colums ? true : false;
}
// Am×n на матрицу Bn×k будет матрица Cm×k 
// когда количество столбцов первой матрицы равно количеству строк второй матрицы.
// Cij = Ai1 · B1j + Ai2 · B2j + ... + Ain · Bnj

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMultiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = default;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                sum += matrix1[i, n] * matrix2[n, j];
            }
            matrixMultiplication[i, j] = sum;
        }
    }
    return matrixMultiplication;
}