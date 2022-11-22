// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.




int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();

ChangeRows(matrix);
PrintMatrix(matrix);

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
void ChangeRows(int[,] matrix)
{
    int i = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[i, j];
        matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}