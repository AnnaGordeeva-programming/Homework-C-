// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

string day_number = " ";
while(true)
{
    Console.Write("Введите номер дня недели (от 1 до 7), чтобы проверить, является ли он выходным: ");
    day_number = Console.ReadLine();
    switch(day_number)
    {
        case "1":
        {
            Console.WriteLine("Нет");
            continue;
        }
        case "2":
        {
            Console.WriteLine("Нет");
            continue;
        }
        case "3":
        {
            Console.WriteLine("Нет");
            continue;
        }
        case "4":
        {
            Console.WriteLine("Нет");
            continue;
        }
        case "5":
        {
            Console.WriteLine("Нет");
            continue;
        }
        case "6":
        {
            Console.WriteLine("Да");
            continue;
        }
        case "7":
        {
            Console.WriteLine("Да");
            continue;
        }
        default:
        {
            Console.WriteLine("Неправильно задан номер");
            break;
        }
    }
}