// Напишите программу, которая принимает
//   на вход любое число и проверяет, 
//   является ли оно палиндромом. Не использовать строки

int Promt(string message)
{
    System.Console.Write($"{message}");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int InputValue = Promt("Введите число, чтобы опеределить, является ли оно полиномом");

int ostatok = InputValue;

int kolichestvoChisel = 1;
int ostatokOtDeleniya = InputValue;

int countIndex = 1;

while (ostatokOtDeleniya > 10)
{
    kolichestvoChisel += 1;
    ostatokOtDeleniya = ostatokOtDeleniya / 10;
}

for (int i = 1; i < kolichestvoChisel; i++)
{
    countIndex = countIndex + 1;
}

int[] arrayVision = new int[countIndex];

for (int i = 0; i < arrayVision.Length; i++)
{
    arrayVision[i] = ostatok % 10;
    ostatok = ostatok / 10;
}

Console.WriteLine(arrayVision[arrayVision.Length]);

if (kolichestvoChisel % 2 == 1)
{
    for (int i = 0; i < arrayVision.Length/2; i++)
    {
        if (arrayVision [i] == arrayVision [kolichestvoChisel]){
            Console.WriteLine("Число является полином");
        }
    }
    if (arrayVision[0] == arrayVision[0]) //&& arrayVision[kolichestvoChisel / kolichestvoChisel] == arrayVision[kolichestvoChisel - 1])
    {
        Console.WriteLine("Число является полином");
    }
    else
    {
        Console.WriteLine("Число не является полиномом");
    }
}
else
{
    Console.WriteLine("Я ещё не придумал");
}