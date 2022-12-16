// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 3");
int c = int.Parse(Console.ReadLine()!);
Console.Write(Triangle(a,b,c));

bool Triangle(int a, int b, int c)
{
    if(a < b +c && b < a+c && c< a+b) return true;
    else return false;
    
}

