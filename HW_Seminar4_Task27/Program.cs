// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numA)
{
   int sum = 0;
   while (numA>0)
   {
    sum = sum + numA%10;
    numA = numA/10;
   }
    return sum;
}

Console.WriteLine(SumNumber(number));