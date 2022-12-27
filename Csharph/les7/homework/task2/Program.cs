//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Ряд > 1
// Колонка > 7

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
            list[i,j]=new Random().Next(1,10);
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
            System.Console.Write($"{matr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int SearchElemnt(int[,] matr, int row, int column) {
    
    
    int value = matr[row,column];
    return value;
}

int m=Prompt("Введите количество строк > ");
int n =Prompt("Введите колличество столбцов > ");

int[,] array=new int[m,n];
PrintArrayTwo(FillArray(array));
int row = Prompt("Введите строку искомого элемента");
int column = Prompt("Введите столбец искомого элемента");
Console.WriteLine(SearchElemnt(array, row, column));