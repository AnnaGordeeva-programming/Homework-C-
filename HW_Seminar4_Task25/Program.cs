// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

/*double Power(double numberA, double numberB)
{
    double power = Math.Pow(numberA, numberB);
    return power;
}

Console.WriteLine(Power(numberA, numberB));*/

int Power(int numberA, int numberB)
{
    int count = 0;
    int result = 1;
    while(count<numberB)
    {
        result = result * numberA;
        count=count+1;
    }
    return result;
}
Console.WriteLine(Power(numberA, numberB));