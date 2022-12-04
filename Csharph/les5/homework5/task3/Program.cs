// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

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

int SumMinMaxValue(int[] array)
{
    int sum = 0;
    int maxValue1 = array[0];
    int minValue = array[0];
    for (int i=0; i < array.Length; i++){        
        if (maxValue1 < array[i])
        {
            maxValue1 = array[i];
        }
        if (minValue > array[i]){
            minValue = array[i];
        }     
    }
    sum = maxValue1 + minValue;
    return sum;

}

int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");

int [] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);
Console.WriteLine("Сумма минимального и максимального элемента равна: "+SumMinMaxValue(arr));