// Задача №3. Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7, чтобы определить день недели ");
int a = int.Parse(Console.ReadLine()!);

if(a >= 1 & a <=7)
{
    if(a == 1)
    {
        Console.WriteLine("Monday");
    }
    if(a == 2)
    {
        Console.WriteLine("Tuesday");
    }
    if(a == 3)
    {
        Console.WriteLine("Wednesday");
    }
    if(a == 4)
    {
        Console.WriteLine("Thursday");
    }
    if(a == 5)
    {
        Console.WriteLine("Friday");
    }
    if(a == 6)
    {
        Console.WriteLine("Saturday");
    }
    if(a == 7)
    {
        Console.WriteLine("Sunday");
}
}
else
{
    Console.WriteLine("Ты ввел не верное число ");
}