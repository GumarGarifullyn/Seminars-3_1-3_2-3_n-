// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет

Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine()!);

if(A == B*B || B == A*A)
{
    Console.WriteLine("Да, одно число является квадратным числом другого");
}
else
{
    Console.WriteLine("Нет");
}