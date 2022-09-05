// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThreeDigits(int number)
{
int result = 0;
while(number>=1000)
{
  result = number/10;
  number = number/10;
}
return result;
}

int interim = ThreeDigits(number);
if(number>=1000)
{
    int thirdNumber = interim % 10;
    Console.WriteLine(thirdNumber);
}
else if(number>=100)
{
    int thirdNumber = number % 10;
    Console.WriteLine(thirdNumber);
}
else Console.WriteLine("Третьей цифры нет");