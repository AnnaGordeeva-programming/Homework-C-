//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
    res[i] = new Random().Next(100, 1000);
    }
    return res;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count; pos++)
    {
        Console.Write(col[pos] + " ");
    }
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
    if(array[i]%2 == 0)
    {
        count = count + 1;
    }
    }
    return count;
}

int[]array = GetArray(10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Count(array));
