// 3.1. Напишите программу, которая будет принимать
//  на вход пять чисел и выводить сумму
//   и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 


int Promt(string message)
{
    System.Console.Write($"{message}");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int quant = Promt("Количество чисел = ");
int index = 0;

double sum = 0;

while (index < quant)
{
    int value1 = Promt($"Введите {index} число ");
    sum = sum + value1;
    index++;
}


double avg = sum / index;

Console.WriteLine("Сумма " + sum);
Console.WriteLine($"Среднее значение = {avg:f2}");