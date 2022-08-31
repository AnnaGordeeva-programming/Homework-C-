// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=100)
{
int a3 = number%10;
Console.WriteLine(a3);
}
else Console.WriteLine("Третьей цифры нет");
