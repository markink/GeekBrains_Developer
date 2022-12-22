// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.



int Promt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int SumOfNaturalNumber(int FirstValue, int FinalValue)
{
    if (FirstValue == FinalValue)
        return FinalValue;
    return FinalValue + SumOfNaturalNumber(FirstValue, FinalValue - 1);
}

int m = Promt("Введите M:");
int n = Promt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {SumOfNaturalNumber(m, n)}");
