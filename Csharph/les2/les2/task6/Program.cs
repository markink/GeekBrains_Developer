// 2.1. Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8


int value1 = new Random().Next(10, 10000);
Console.WriteLine(value1);

int max = 0;

while (value1 >0) {
    int num = value1 % 10;
    value1 = value1/10;
    if  (max < num){
        max = num;
    }
}
Console.WriteLine("Наибольшая цифра числа " + max);

