// Задача 4: Задайте двумерный массив. 
// Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали,
//  или напишите, что такого элемента нет.
//  Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.


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



int m=Prompt("Введите количество строк > ");
int n =Prompt("Введите колличество столбцов > ");

int[,] array=new int[m,n];
PrintArrayTwo(FillArray(array));