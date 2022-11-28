// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int Promt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int value1 = Promt("Введите число: ");

if (value1 < 0 ) {
    value1 = -value1;
}

for (int i = 1; i <= value1; i++)
{
    Console.Write(i * i + " ");
}
