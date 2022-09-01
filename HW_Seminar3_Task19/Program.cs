// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string number = Console.ReadLine();
int number_length = number.Length;

for(int i=0; i<number_length/2; i++)
{
    if(number[i] != number[number_length-i-1])
    {
        Console.WriteLine("Нет");
    }
    else Console.WriteLine("Да");
}