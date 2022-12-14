//  Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

double[,] FillArray(double[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            list[i,j]=new Random().NextDouble() + new Random().Next(1, 10);
        }
    }
    return list;
}
 void PrintArrayTwo(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int m =Prompt("Введите количество строк > ");
int n =Prompt("Введите колличество столбцов > ");

double [,] array= new double[m,n];
PrintArrayTwo(FillArray(array));