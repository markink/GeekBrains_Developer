// Напишите программу замены элементов массива:
//  положительные элементы замените 
//  на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GenerateArray(int Length, int minRange, int maxRange)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange+1);
    }
    return array;
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

int[] ReserveArray (int [] numbers) {
    for (int i=0; i<numbers.Length; i++) {
        numbers[i] = -numbers[i]; 
    }
    return numbers;
}

int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");


int [] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);

ReserveArray(arr);
PrintArray(arr);

