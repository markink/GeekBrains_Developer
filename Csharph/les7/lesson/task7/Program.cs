// Задайте двумерный массив. 
// Найдите максимальный элемент 
// массива и среднее арифметическое
//  всех элементов массива.
// Например, такой массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25


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

int MaxArrayIndex (int [,] array)
{
    int maxIndex = array[0,0];

    foreach (int item in array)
    {
        if (maxIndex < item) {
            maxIndex = item;
        }
    } 
    return maxIndex;
}

double Average (int [,] array)
{
    double sum = 0;
    int count = 0;

    foreach (int item in array)
    {
        sum = sum + item;
        count++;
    } 
    return (sum/count);
}

int m =Prompt("Введите количество строк > ");
int n =Prompt("Введите колличество столбцов > ");

int[,] array=new int[m,n];
PrintArrayTwo(FillArray(array));
Console.WriteLine(MaxArrayIndex(array));
Console.WriteLine(Average(array));
