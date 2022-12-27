//  Задайте двумерный массив. 
//  Напишите программу, которая поменяет 
//  местами первую и
//   последнюю строку массива.

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

int[,] ReverseRowsArray(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int lastRow = matr.GetLength(0) - 1;

        int number = matr[0,i];
        matr [0,i] = matr[lastRow, i];
        matr [lastRow, i] = number;
    }
    return matr;
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");

int[,] array = new int[m, n];
PrintArrayTwo(FillArray(array));
Console.WriteLine();
int[,] reserveArray = ReverseRowsArray(array);
PrintArrayTwo(reserveArray);
Console.WriteLine("Вторая матрица ");
PrintArrayTwo(array);