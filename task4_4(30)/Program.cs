// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] Array()
{
    Console.WriteLine("Введите длину массива");
    int len = int.Parse(Console.ReadLine()!);
    int[] array = new int[len];

    for(int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 2);
        
        if(i == 0) Console.Write($"[{array[i]}, ");
        if(i == len-1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
        return array;
}

Array();