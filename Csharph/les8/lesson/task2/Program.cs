// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая заменяет 
// строки на столбцы. В случае, 
// если это невозможно, программа должна
//  вывести сообщение для пользователя.

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[,] FillArray(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            list[i, j] = new Random().Next(1, 10);
        }
    }
    return list;
}

void PrintArrayTwo(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] Transpon(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int Number = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = Number;
        }

    }
    return matrix;
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");

int[,] array = new int[m, n];
PrintArrayTwo(FillArray(array));
System.Console.WriteLine();
PrintArrayTwo(Transpon(array));

