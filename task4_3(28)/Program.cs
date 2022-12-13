// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Amount(int number)
{
    int multy = 1;
    while(number > 0)
    {
        multy=multy*number;
        number--;
    }
    return multy;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Amount(num));
