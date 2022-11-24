// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0) return;
    // Console.Write($"{num} "); // если поставить тут то будет выводить числа в обратном порядке, т.к. стоит между методами
    NaturalNumbers(num - 1); // в стэке сохраняется значение текущего num пред началом выполнения функции с (num-1) (5 4 3 2 1)
    Console.Write($"{num} "); // значения хранятся в стэке пока не будет выполнено условие выхода из рекурсии. Затем печатает по очеди из стэк
}

// вариант с другим условием

// void NaturalNumbers(int num) //5
// {
//     if (num > 0)
//     {
//         NaturalNumbers(num - 1);
//         Console.Write($"{num} ");
//     }
// }

NaturalNumbers(number);