// Задача 3: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

int [] Fibonacci (int argument) {
    int [] FibRow = new int [argument];
    FibRow [0] = 0;
    FibRow [1] = 1;

    for (int i = 2; i < argument; i++)
    {
        FibRow[i] = FibRow[i-1] + FibRow[i-2];
    }
    return FibRow;
}

int length = Prompt("Введите число ");
PrintArray(Fibonacci(length));