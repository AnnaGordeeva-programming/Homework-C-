// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

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