// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

Console.Write("Введите X(a): ");
double xa = double.Parse(Console.ReadLine());//Convert.ToDouble

Console.Write("Введите Y(a): ");
double ya = double.Parse(Console.ReadLine());

Console.Write("Введите Z(a): ");
double za = double.Parse(Console.ReadLine());

Console.Write("Введите X(b): ");
double xb = double.Parse(Console.ReadLine());

Console.Write("Введите Y(b): ");
double yb = double.Parse(Console.ReadLine());

Console.Write("Введите Z(b): ");
double zb = double.Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
Console.WriteLine(ab);