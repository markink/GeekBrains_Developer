// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.

int Promt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int value1 = Promt("Введите число: ");

if (value1 > 0)
{
    for (int i = 1; i <= value1; i++)
    {
        Console.Write(i * i * i + " ");
    }
}
else
{
    for (int i = 1; i >= value1; i--)
    {
        Console.Write(i * i * i + " ");
    }
}

