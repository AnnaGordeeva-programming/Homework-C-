// Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

void FillArray(int[] array)
{
    int index = 0;
    while(index<array.Length)
    {
        array[index] = new Random().Next(1,100);
        index++;
    }
}

void PrintArray(int[] array)
{
    int index = 0;
    while(index<array.Length)
    {
        Console.Write($"{array[index]} ");
        index++;
    }
}

int[] newArray = new int[8];
FillArray(newArray);
PrintArray(newArray);