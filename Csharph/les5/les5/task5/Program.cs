// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. 
// Результат запишите в новом массиве

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

int[] MultiValueIndex(int[] array)
{
    int [] result = new int [array.Length/2 + array.Length%2];
    result[result.Length -1] = array[result.Length -1];
    for (int i=0; i < array.Length/2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;

}

int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");

int[] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);
Console.WriteLine("   ");
PrintArray(MultiValueIndex(arr));
