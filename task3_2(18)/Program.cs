// Задача №18. Работа в группах
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти от 1 до 4:");
int num = int.Parse(Console.ReadLine()!);

if (num == 1) Console.WriteLine("x > 0; y > 0");
if (num == 2) Console.WriteLine("x < 0; y > 0");
if (num == 3) Console.WriteLine("x < 0; y < 0");
if (num == 4) Console.WriteLine("x > 0; y < 0");
if(num <= 0 && num > 4) Console.WriteLine("Введен неверный диапазон");