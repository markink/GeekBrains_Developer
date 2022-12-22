//  Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 1 | 3 4
// 3 2 1 | 3 3
// _ _ _ | 1 1
// Результирующая матрица будет:
// 19 21
// 16 19

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

void MultiplicationTwoArray (int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int rows1 = Prompt("Введите количество строк первой матрицы ");
int column1 = Prompt("Введите колличество столбцов первой матрицы ");

int rows2 = Prompt("Введите количество строк второй матрицы ");
int column2 = Prompt("Введите колличество столбцов второй матрицы ");

Console.WriteLine("Матрица 1:");
int[,] firstArray = new int[rows1, column1];
PrintArrayTwo(FillArray(firstArray));

Console.WriteLine("Матрица 2:");
int[,] secondArray = new int[rows2, column2];
PrintArrayTwo(FillArray(secondArray));

int [,] resultMatr = new int[rows1, column2];


if (column1 == rows2){
MultiplicationTwoArray(firstArray, secondArray, resultMatr);
PrintArrayTwo(resultMatr);
} else {
    Console.WriteLine("Для умножения оличество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
}



