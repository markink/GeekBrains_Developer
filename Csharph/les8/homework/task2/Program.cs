//  Задайте прямоугольный двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка

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

int MinimalSumOfRowsArray (int[,] matr, int rowIndex)
{
    
    int sum = 0;
    
    
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr [rowIndex, j];
        }
    
    return sum;
    

}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");


int[,] array = new int[m, n];
PrintArrayTwo(FillArray(array));
Console.WriteLine();
int index = 0;
int minValue = MinimalSumOfRowsArray(array, 0) ;
for (int i = 1; i < m; i++)
{    
    
    if (minValue > MinimalSumOfRowsArray(array, i)) {
       minValue = MinimalSumOfRowsArray(array, i);
       index = i+1;        
    }
}

Console.WriteLine($"Минимальное сумма чисел равна {minValue}, это строка: {index}");

