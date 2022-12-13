// Задача *: Напишите программу,
//  которая из массива случайных чисел.
// Ищет второй максимум 
// (число меньше максимального элемента, 
// но больше всех остальных).
//    Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

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

int maxValueIndex(int[] array)
{
    int maxValue1 = int.MinValue; // 3    3 3 5
    int maxValue2 = int.MinValue; // min  1 2 3
    for (int i = 0; i < array.Length; i++)
    {
        if (maxValue1 < array[i])
        {
            maxValue2 = maxValue1;
            maxValue1 = array[i];                       
        } else if (maxValue2 <= array[i] & maxValue2 < maxValue1) {
            maxValue2 = array[i];
        }
    }

    return maxValue2;
}

int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");

int[] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);
Console.WriteLine("Второй максимум массива равен: " + maxValueIndex(arr));