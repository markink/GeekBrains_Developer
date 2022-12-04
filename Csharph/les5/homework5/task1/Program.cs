//  Задайте массив заполненный 
//  случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет 
//  количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




int[] GenerateArray(int Length, int minRange, int maxRange)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int OddValue(int[] array)
{
    int index = 0;
    for (int i=0; i < array.Length; i++){
        if (array[i]%2 == 0){
            index +=1;
        }
    }
    return index;

}

int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");

int [] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);
Console.WriteLine("Количество чётных чисел равно"+OddValue(arr));