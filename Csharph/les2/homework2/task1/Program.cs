// Задача 1: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Не использовать строки


int Promt(string message)
{
    System.Console.Write($"{message}");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int input1 = Promt("Введите трёхзначное число ");

int ostatok = input1/10%10;

if (input1 >= 100 && input1 < 1000)
{
    Console.WriteLine(ostatok);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}