// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
if(matrix.GetLength(0) == matrix.GetLength(1))
{
// int[,] newMatrix = ChangeRowsColums(matrix);
// PrintMatrix(newMatrix);
ChangeRowsColums(matrix);
PrintMatrix(matrix);
}
else Console.WriteLine("Массив не симметричен");


// Методы

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

// int[,] ChangeRowsColums(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[i,j] = matrix[j,i];
//         }
//     }
//     return newMatrix;
// }

void ChangeRowsColums(int[,] matrix)
{
    int temp = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
}