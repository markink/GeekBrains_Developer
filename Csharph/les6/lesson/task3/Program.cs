// Напишите программу, которая будет 
// преобразовывать десятичное число
//  в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Функция вывода приглашения и ввода целого числа
int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}


int [] NumberToBinary (int value) {
    int index = 0;
    int [] number = new int [8];
    while (value > 0) {
        ostatok = value%2;
        number [index] = ostatok;
        value = value/2;
        index++;
    }
}


void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

int number = Prompt("Введите число: ");
PrintArray(NumberToBinary(number));
