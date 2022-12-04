//  Задайте одномерный массив из 123 случайных чисел. 
//  Найдите количество элементов массива, 
//  значения которых лежат в отрезке [10,99]. 

int[] CreateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void QuantityValue(int[] arr, int minValue, int maxValue)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] >= minValue & arr[i] < maxValue){
            index +=1;
        }
    }
    Console.WriteLine("Число элементов в заданном дипазаное равно"+index);
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
    System.Console.WriteLine();
}

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Length = Promt("Введите длину массива: ");
int minRange = Promt("Введите минимальное число в массиве: ");
int maxRange = Promt("Введите максимальное число в массиве: ");
int minFindValue = Promt("Введите минимальное число которое надо найти: ");
int maxFindValue = Promt("Введите максимальное число которое надо найти: ");

int [] array = CreateArray(Length, minRange, maxRange);

PrintArray(array);
QuantityValue(array, minFindValue, maxFindValue);

