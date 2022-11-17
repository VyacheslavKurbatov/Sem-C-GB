// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.


Console.Write("Задайте кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте кол-во столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, colums, 0, 10);
PrintMatrix(array2D);

Console.WriteLine();
 int sumDiagonal = SumDiagonal(array2D);
 Console.WriteLine($"{sumDiagonal}");


int SumDiagonal(int[,] matrix)
{
    int sum = default;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i,i];
    }

    // for (int i = 0; i < matrix.GetLength(0); i += 2)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j += 2)
    //     {
    //         if (i == j)
    //         {
    //             sum = sum + matrix[i, j];
    //         }
    //     }
    // }
    return sum;
}

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}