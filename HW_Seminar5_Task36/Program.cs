// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
    res[i] = new Random().Next(0, 100);
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

int OddSum (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

int[]array = GetArray(10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(OddSum(array));