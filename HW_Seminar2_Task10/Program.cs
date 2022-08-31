//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number<1000 && number>=100)
{
int a1 = number/100;
int a2 = (number-a1*100)/10;
Console.WriteLine(a2);
}
else Console.WriteLine("Некорректный ввод данных. Введите ТРЕХЗНАЧНОЕ число");
