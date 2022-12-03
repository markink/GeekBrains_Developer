// Задача 1: Напишите программу,
//  которая принимает на вход число 
//  и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int value1 = Promt("Введите число: ");

int Counter(int value1)
{
    int index = 0;

    while (value1 > 0)
    {
        value1 = value1 / 10;
        index += 1;
    }
    return index;
}

Console.WriteLine($"Количество цифр в числе {value1} равно: {Counter(value1)}");