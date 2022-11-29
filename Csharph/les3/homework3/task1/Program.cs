// Напишите программу, которая принимает
//   на вход пятизначное число и проверяет, 
//   является ли оно палиндромом. Не использовать строки

int Promt(string message)
{
    System.Console.Write($"{message}");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int InputValue = Promt("Введите пятизначное число");

int ostatok = InputValue;

int[] arrayVision = new int [5];

for (int i = 0; i<arrayVision.Length; i++){
    arrayVision [i] = ostatok%10;
    ostatok = ostatok/10;
}

if (InputValue/10000 >= 1 && InputValue/10000 <= 9) {
    if (arrayVision[0] == arrayVision [4] && arrayVision[1] == arrayVision[3]){
        Console.WriteLine("Число является полином");
    } else {
        Console.WriteLine("Число не является полиномом");
    }
    
} else {
    Console.WriteLine("Число не пятизначное");
}