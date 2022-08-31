//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=number; i++)
{
    if(i%2 == 0) Console.Write($"{i} ");
}

//Можно сделать счетчик через 2 и начать с 2 сразу
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//for(int i=2; i<=number; i=i+2)
//{
//    Console.Write($"{i} ");
//}