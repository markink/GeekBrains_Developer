// Задача 3: Задайте двумерный массив. 
// Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

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
 
void PrintSumMainDiagonal (int [,] array) {
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) {
                sum = sum + array[i,j];
            }
        }
    }
    Console.Write($"Длина массива равен: {sum}");
}

void PrintSumMainDiagonal2 (int [,] array) {
    int sum = 0;
    for (int i = 0; array.GetLength(0); i++){
        sum = sum + array[i,i];
    }    
    Console.Write($"Длина массива равен: {sum}");
}

int m=Prompt("Введите количество строк и слобцов >  ");

int[,] array=new int[m,m];
PrintArrayTwo(FillArray(array));
PrintSumMainDiagonal2(array);
