// Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Promt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int FirstValue, int FinalValue)
{
    if (FirstValue == 0)
        return FinalValue + 1;
    if (FirstValue > 0 && FinalValue == 0)
        return Akkerman(FirstValue - 1, 1);
    else
        return Akkerman(FirstValue - 1, Akkerman(FirstValue, FinalValue - 1));
}

int m = Promt("Введите положительное число M:");
int n = Promt("Введите положительное число N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {Akkerman(m, n)}");
