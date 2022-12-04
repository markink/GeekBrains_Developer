// Задайте массив. Напишите программу,
//  которая определяет, присутствует 
//  ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

void FindValue(int value, int [] arr) {
    bool isFound = false;
    for (int i=0; i < arr.Length; i++){
        if (arr[i] == value){
            isFound = true;
        } 
    }
    if (isFound != true) {
        Console.WriteLine("Такого числа нет в массиве.");
    } else {
        Console.WriteLine("Число присутсвтует в массиве.");
    }
}


int Range = Promt("Введите длину массива ");
int minValue = Promt("Введите минимальное значение ");
int maxValue = Promt("Введите максимальное значение ");
int findValue = Promt("Введите число, какое надо найти в массиве ");


int [] arr = GenerateArray(Range, minValue, maxValue);
PrintArray(arr);
FindValue(findValue, arr);




