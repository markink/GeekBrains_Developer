// Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа
//  в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void NaturalNumber(int numberStart, int numberFinish)
{
    if (numberStart == numberFinish)
    {
        return;
    }

    NaturalNumber(numberStart, numberFinish - 2);
    System.Console.Write($"{numberFinish}; ");
}

int number1 = Prompt("Введите первое положительное число");
int number2 = Prompt("Введите первое положительное число");



if (number1 > 0 && number2 > 0)
{
    if (number1 < number2)
    {
        if (number2 % 2 == 0 & number1 % 2 == 0)
        {
            NaturalNumber(number1, number2);
        }
        else if (number2 % 2 == 1 & number1 % 2 == 1)
        {
            number2 = number2 - 1;
            number1 = number1 -1;
            NaturalNumber(number1, number2);
        }
        else if (number2 % 2 == 0 & number1 % 2 == 1)
        {
            
            number1 = number1 -1;
            NaturalNumber(number1, number2);
        }
        else if (number2 % 2 == 1 & number1 % 2 == 0)
        {
            number2 = number2 - 1;
            NaturalNumber(number1, number2);
        }


    }
    else
    {
        if (number2 % 2 == 0 & number1 % 2 == 0)
        {
            NaturalNumber(number2, number1);
        }

        if (number2 % 2 == 1 & number1 % 2 == 1)
        {
            number2 = number2 - 1;
            number1 = number1 -1;
            NaturalNumber(number2, number1);
        }

        if (number2 % 2 == 1 & number1 % 2 == 0)
        {
            number2 = number2 - 1;
            
            NaturalNumber(number2, number1);
        }
        if (number2 % 2 == 0 & number1 % 2 == 1)
        {
            
            number1 = number1 -1;
            NaturalNumber(number2, number1);
        }
    }
}
else
{
    Console.WriteLine("Введите положительные числа");
}

