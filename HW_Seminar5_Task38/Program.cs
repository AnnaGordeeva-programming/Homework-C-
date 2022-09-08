// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

void PrintArray(double[] col)
{
    int count = col.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(col[pos] + " ");
    }
}

double FindMax(double[] array)
{
    double max = array[0];
    int i = 0;
    while (i < array.Length)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
        i++;
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    int i = 0;
    while (i < array.Length)
    {
        if(array[i]<min)
        {
            min = array[i];
        }
        i++;
    }
    return min;
}

double[] array = GetArray(10);
PrintArray(array);
Console.WriteLine();

double max = FindMax(array);
Console.WriteLine($"max = {max}");

double min = FindMin(array);
Console.WriteLine($"min = {min}");

Console.WriteLine($"Разница между max и min равняется {max-min}");