// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int EvenValue(int[] array)
{
    int sum = 0;
    for (int i=0; i < array.Length; i += 2){        
        sum = sum + array[i];        
    }
    return sum;

}

int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");

int [] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);
Console.WriteLine("Сумма элементов на нечётных позициях равна: "+EvenValue(arr));