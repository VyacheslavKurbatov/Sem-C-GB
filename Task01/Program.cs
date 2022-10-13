// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


// bool rresult = number == square; // true - false
// if(number == square && number > 5 || number < 0) // && -логическое "и" (&& number > 5) || - логическое "или" (|| number < 0) == - логическое "равно"
// {

// }
// else
// {
    
// }

Console.WriteLine("Введите целое число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine($"число {number1} равно квадрату {number2}");
}
else 
{
    Console.WriteLine($"число {number1} не равно квадрату {number2}");
}

