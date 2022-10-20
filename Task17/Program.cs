// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("введите координаты точки");
Console.Write("X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Y:");
int y = Convert.ToInt32(Console.ReadLine());

int Quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

// если тип void (ничего не возвращает) (так делать нельзя)
// void Quater(int xc, int yc)  
// {
//     if (xc > 0 && yc > 0) Console.WriteLine(1);
//     else if (xc < 0 && yc > 0) Console.WriteLine(2);
//     else if (xc < 0 && yc < 0) Console.WriteLine(3);
//     else if (xc > 0 && yc < 0) Console.WriteLine(4);
//     Console.WriteLine(0);
// }

int quater = Quater(x, y);
string result = quater > 0 ? $"Указанная координаты соответствует четверти -> {quater}" : "Введены некорректные координаты"; // тернарный оператор
//         если quater > 0 то   выводим ...                                          иначе выводим ...

Console.WriteLine(result); 
