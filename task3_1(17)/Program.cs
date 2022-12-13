// Задача №17. Напишите программу, которая
// принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.


Console.WriteLine("Введите координату x:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y:");
int y = int.Parse(Console.ReadLine()!);
if (x > 0 && y > 0) Console.WriteLine("I");
if (x < 0 && y > 0) Console.WriteLine("II");
if (x < 0 && y < 0) Console.WriteLine("III");
if (x > 0 && y < 0) Console.WriteLine("IV");