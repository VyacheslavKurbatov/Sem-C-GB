// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" ]");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] NewArray(int[,] matrix)
{
    int count = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}
void CountElements(int[] array)
{
    int elem = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (elem == array[i]) count++;
        else
        {
            Console.WriteLine($"Элементов {elem} => {count}");
            elem = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Элементов {elem} => {count}");
}

int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 10);
Console.WriteLine("массив заполненный случайными целыми числами");
PrintMatrix(newMatrixRndInt);
Console.WriteLine();
int[] newArray = NewArray(newMatrixRndInt);
Array.Sort(newArray);
Console.WriteLine("сортированный одномерный массив");
PrintArray(newArray);
Console.WriteLine();
CountElements(newArray);