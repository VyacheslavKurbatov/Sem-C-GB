// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Программа возвращает значние элемента массива по заданным индексам");

// Программа

Random rnd = new Random();
int size = rnd.Next(2, 7);  // создаем псевдослучайное число для задания размера массива

int[,] rndMatrix = CreateMatrixRndInt(size, size, -10, 10); // создаем матрицу
PrintMatrix(rndMatrix); // печатаем матрицу

Console.Write("Введите необходимую строку: ");     // вводим искомые индексы
var indexRow = Console.ReadLine();
Console.Write("Введите неоходимый столбец: ");
var indexColums = Console.ReadLine();

int i = ConvertEnteredData(indexRow);       // проверяем и конвертируем исходные данные
int j = ConvertEnteredData(indexColums);

if (CheckedIndex(rndMatrix, i, j) == true)
{
    int result = rndMatrix[i, j]; // i - 1 и j - 1 если ориентироваться на пользователя не знающего что начинается с 0
    Console.WriteLine($"Элемент с индексами ({indexRow} , {indexColums}) -> {result}");
}
else Console.WriteLine($"Элемента с индексами ({indexRow} , {indexColums}) нет");


// Функции

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)   // Создает и заполняет матрицу случайными числами
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

bool CheckedIndex(int[,] matrix, int indexI, int indexJ) // проверяет индексы на наличие в матрице
{
    if (indexI <= matrix.GetLength(0)
        && indexI >= 0
        && indexJ <= matrix.GetLength(1)
        && indexJ >= 0
      )
    {
        return true;
    }
    else return false;
}

bool CheckingEnteredData(string enteredData)    // проверяет являются ли введенные данные натуральными числами 
{
    bool isNumIndex = int.TryParse(enteredData, out _);
    return isNumIndex;
}

int ConvertEnteredData(string enteredData)  // проверяет введенные данные и конвертирует их в числа
{
    if (CheckingEnteredData(enteredData) == true)
    {
        int index = Convert.ToInt32(enteredData);
        return index;
    }
    else return -1; // число, которое не входит в искомый в задании диапазон (равносильно false)
}
