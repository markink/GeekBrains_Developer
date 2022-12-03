// Задача 2: Напишите программу,
//  которая принимает на вход число
//   и выдаёт сумму цифр в числе.
//   Реализовать через функции.

int Promt(String message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int inputValue = Promt("Введите число: ");

int SumNumbers(int value)
{
    int sumValues = 0;
    while (value >= 1) {
        sumValues = sumValues + value%10;
        value = value/10;
    }  
    return sumValues;     
}
Console.Write("Сумма чисел будет равна: " + SumNumbers(inputValue));
