// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B: ");
double numberB = Convert.ToDouble(Console.ReadLine());

double Power(double numberA, double numberB)
{
    double power = Math.Pow(numberA, numberB);
    return power;
}

Console.WriteLine(Power(numberA, numberB));