// : Напишите программу, 
// которая выводит случайное трёхзначное число и
//  удаляет вторую цифру этого числа. 
//  Не использовать строки для расчета

int randomValue = new Random().Next(100, 1000);

Console.WriteLine(randomValue);

int sotni = randomValue/100;
int desyatki = randomValue/10%10;
int edinici = randomValue%10;

int OutputValue = sotni*10+edinici;

Console.WriteLine(sotni+" "+desyatki+" "+edinici);

Console.WriteLine(OutputValue);