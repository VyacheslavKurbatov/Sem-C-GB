// Задача 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// Например: 
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // последнее число не включается в диапозон, а первое включено
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // 78/10 = 7 т.к. целочисленное деление
int secondDigit = number % 10; // 78%10 = 8 т.к. это остаток от деления

// условный оператор
// int result = default; // default это дефолтное значение переменной (в данном случае у int это 0)
// if(firstDigit > secondDigit) result = firstDigit;
// else result = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {result}");

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {secondDigit}");

// тернарный оператор 1
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // (тернарный оператор) если первое число больше второго тогда мы записываем в переменную max первую цифру, иначе записываем в переменную max вторую цифру
Console.WriteLine($"Наибольшая цифра числа {maxDigit}");

// int res = Math.Max(FirstDigit, SecondDigit);  // встроенная математическая функция
// Console.WriteLine(res);

// тернарный оператор 2
Console.Write($"Наибольшая цифра числа {number} равна ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit); // в таком случае не нужна новая переменная
