// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату x точка A:");
int ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки A:");
int ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату x точка B:");
int bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки B:");
int by = int.Parse(Console.ReadLine()!);
double dis = Math.Round(Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay)),2);
Console.WriteLine(dis);