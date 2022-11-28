// Задача 2: Напишите программу,
//  которая по заданному номеру четверти, 
//  показывает диапазон возможных
//  координат точек в этой четверти (x и y).

int Promt(string message)

{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

double quater = Promt("Введите номер четверти: ");

switch (quater)
{
    case 1:
        System.Console.WriteLine("Дипазон значения x > 0, y > 0");
        break;

    case 2:
        System.Console.WriteLine("Дипазон значения x < 0, y > 0");
        break;

    case 3:
        System.Console.WriteLine("Дипазон значения x < 0, y < 0");
        break;

    case 4:
        System.Console.WriteLine("Дипазон значения x > 0, y < 0");
        break;

    default:
        System.Console.WriteLine("Это не соответсвует номеру четверти.");
        break;
}
