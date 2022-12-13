// Задача 1: Напишите цикл, 
// который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
//   Реализовать через функции.

int Promt (String message) {
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int inputValue1 = Promt("Введите число А: ");
int inputValue2 = Promt("Введите число B: ");



int Rate (int value1, int value2) {
    int result = 1;
    for (int i = 1; i <= inputValue2; i++) {
        result = result*inputValue1;
    }
    return result;
}

Console.WriteLine(Rate(inputValue1, inputValue2));
