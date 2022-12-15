// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double [] ArraySearchElemnt(int[,] matr, int columns, int rows)
{
    double [] array = new double [columns];

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            array[i] = array [i] + matr[j, i];
        }
        array[i] = array[i] / rows;
    }

    return array;
    
}

void PrintArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        int index = j+1;
        Console.WriteLine("Средние значение элементов столбца "+ index + " равно: " + array[j] + " ");
    }
}

int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");

int[,] matr = new int[m, n];
PrintArrayTwo(FillArray(matr));
double [] arr = ArraySearchElemnt(matr, n, m);
PrintArray(arr);

