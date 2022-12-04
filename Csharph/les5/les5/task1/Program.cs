// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] CreateArray(int Length, int minRange, int maxRange)
{
    int[] numbers = new int[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange + 1);
    }
    return numbers;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }
}

int SumSighn(int[] array, bool isPositive = true)
{
    int sign = 1;
    if (!isPositive)
    {
        sign = 1;
    }

    int sum = 0;

    foreach (var item in array)
    {
        if (item * sign < 0)
        {

            sum += item;
        }

    }
    return sum;
}


int Length = 12;
int minValue = -9;
int maxValue = 9;

int[] array = CreateArray(Length, maxValue, minValue);

PrintArray(array);

int sumPlus = SumSighn(array);
int sumMinus = SumSighn(array, false);

System.Console.WriteLine($"Summa polojitelnih chisel{sumPlus}a otrcictelnih takaya {sumMinus}");
