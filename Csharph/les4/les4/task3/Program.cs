// Напишите программу, которая принимает на
//  вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24


int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int value = Promt("Введите число: ");

int Vichislenie (int value) {
    int value2 = 1;
    for (int i=1; i<=value; i++){
        value2 = value2 * i;
    
    }
    return value2;
}

Console.WriteLine($"Произведение чисел от 1 до {value} будет равно {Vichislenie(value)}");