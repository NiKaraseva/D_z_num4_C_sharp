/* Программа, которая задаёт массив из 8 рандомных элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

// Способ 1

/* int[] array = new int[8];

void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count; pos++)
    {
        Console.Write($"{col[pos]} ");
    }
}

FillArray(array);
PrintArray(array); */


// Способ 2

int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}






























