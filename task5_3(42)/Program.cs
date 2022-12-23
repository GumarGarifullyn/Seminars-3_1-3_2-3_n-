// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


string Number (int num)
{
    string count = "";
    while(num>=1)
    {
        count = (num%2) + count;
        num = num/2;
      
    }
    return count;
}
Console.Write(Number(45));