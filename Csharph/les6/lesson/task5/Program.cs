﻿// Задача 4: Напишите программу,
//  которая будет создавать копию
//   заданного массива с помощью 
//   поэлементного копирования.

int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}


int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}  ");
    }
    System.Console.WriteLine();
}

int [] CopyArray (int [] array) {
    int [] array2 = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];

    }

    return array2;
}


int [] array = GenerateArray(Prompt("Введите длину массива"));

PrintArray(array);

int [] array2 = CopyArray(array);

array[0] = 999;
PrintArray(array);
PrintArray(array2);