//  Задайте двумерный массив. Найдите элементы, 
//  у которых обе позиции чётные,
//   и замените эти элементы на их квадраты.

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
            list[i,j]=(i+1)*(j+1);
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
            System.Console.Write($"{matr[i,j]} \t");
        }
        System.Console.WriteLine();
    }
}

int [,] ChangeArray (int [,] list) {
    for  (int i = 1; i < list.GetLength(0); i +=2){
        for (int j = 1; j < list.GetLength(1); j +=2)
        {
            list[i,j] = list[i,j]*list[i,j];
        }
    }
    return list;
}

int m =Prompt("Введите количество строк > ");
int n =Prompt("Введите колличество столбцов > ");

int[,] array=new int[m,n];
PrintArrayTwo(FillArray(array));
int [,] array2 = ChangeArray(array);
PrintArrayTwo(array2);
