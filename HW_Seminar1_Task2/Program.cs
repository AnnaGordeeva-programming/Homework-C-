// Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

Console.Write("Число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2) Console.WriteLine($"max = {number1}");
else Console.WriteLine($"max = {number2}");