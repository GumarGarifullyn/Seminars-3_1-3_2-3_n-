// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да 

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);

if (A % 7 == 0 && A % 23 == 0) Console.WriteLine("Yes");
else Console.WriteLine("No");