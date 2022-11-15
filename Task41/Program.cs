// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Программа показывает сколько из введенных чисел больше 0");
Console.Write("Сколько чисел вы хотите ввести? : ");
int size = Convert.ToInt32(Console.ReadLine());

int newSizeArray = NewSizeArray(size);
int[] arr = EnterNumbers(newSizeArray);
PrintArray(arr);
int result = MoreThenZero(arr);
Console.WriteLine($"Количество введенных чисел больше 0 = {result}");


int MoreThenZero(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) sum ++;
    }
    return sum;
}

int[] EnterNumbers(int size)
{
    Console.WriteLine("Вводите числа : ");
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    // Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.WriteLine($"{array[i]}");
    }
    // Console.WriteLine("]");
}

bool CheckingEnterData(int number)
{
    if (number > 0) return true;
    else return false;
}

int NewSizeArray(int size)
{
    int newSize = default;
    if (size <= 0)
    {
        newSize = size;
        if (CheckingEnterData(newSize) == false)
        {
            Console.WriteLine("Колличество не может быть равено или меньше 0");
            Console.Write("Сколько чисел вы хотите ввести? : ");
            newSize = Convert.ToInt32(Console.ReadLine());

            while (CheckingEnterData(newSize) == false)
            {
                Console.WriteLine("Колличество не может быть равено или меньше 0");
                Console.Write("Сколько чисел вы хотите ввести? : ");
                newSize = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    else newSize = size;
    return newSize;
}