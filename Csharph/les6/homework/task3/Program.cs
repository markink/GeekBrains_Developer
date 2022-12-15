// * Найдите максимальное значение в матрице по каждой строке
// , получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами)
//  вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

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

void PrintArrayRows(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        int index = j + 1;
        Console.WriteLine("Максимальное значение элемента строки " + index + " равно: " + array[j] + " ");
    }
}
void PrintArrayColumns(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        int index = j + 1;
        Console.WriteLine("Минимальное значение элемента столбца " + index + " равно: " + array[j] + " ");
    }
}

int[] SearchMaxElemnt(int[,] matr, int column)
{
    int[] max = new int[column];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > max[i])
            {
                max[i] = matr[i, j];
            }
        }
    }
    return max;
}

int[] SearchMinElemnt(int[,] matr, int row)
{
    int[] min = new int[row];
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        min [i] = matr [0,i];
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            if (matr[j, i] < min[i])
            {
                min[i] = matr[j, i];
            }
        }
    }
    return min;
}

int FinalResult (int [] array1, int [] array2) {
    int sum1 = 0;
    int sum2 = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        sum1 = sum1 + array1[i];
    }

    for (int j = 0; j < array2.Length; j++)
    {
        sum2 = sum2 + array2[j];
    }

    return sum1-sum2;
}


int m = Prompt("Введите количество строк > ");
int n = Prompt("Введите колличество столбцов > ");

int[,] matr = new int[m, n];
PrintArrayTwo(FillArray(matr));

PrintArrayRows(SearchMaxElemnt(matr, m));
PrintArrayColumns(SearchMinElemnt(matr, n));

Console.WriteLine(FinalResult(SearchMaxElemnt(matr, m), SearchMinElemnt(matr, n)));

