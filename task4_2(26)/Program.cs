// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Amount(int number)
{
    int sum = 0;
    while(number > 1)
    {
        number = number/10;
        sum = sum + 1;
    }
    return sum;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Amount(num));
