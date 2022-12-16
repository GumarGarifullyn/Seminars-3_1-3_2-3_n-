// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();
int[] copArray = CopyArray(array);
Console.WriteLine(string.Join(" ", copArray));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}

