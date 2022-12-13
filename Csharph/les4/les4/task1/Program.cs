

int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int number)
{
    int sum = 0;
    int i = 1;
    while (i <= number) {
        sum += i;
        i++;
    }

    return sum;
}

int SumGausNumbers (int number){
    return (number + 1)/number/2;
}

int number = Promt("Введите число > ");
int result = SumNumbers(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} сумма будет равна{result}");
int result2 = SumNumbers(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} сумма будет равна{result}");
int result3 = SumGausNumbers(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} сумма будет равна{result}");
