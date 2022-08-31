// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Write("Число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int Max(int number1, int number2, int number3)
{
    int max = number1;
    if(number2>max) max = number2;
    if(number3>max) max = number3;
    return max;
}
int max_number = Max(number1, number2, number3);
Console.WriteLine($"max = {max_number}");