// Напишите программу,
//  которая принимает на вход цифру, 
//  обозначающую день недели, 
//  и проверяет, является ли этот день выходным. 
//  Не использовать строки

int Promt(string message)
{
    System.Console.Write($"{message}");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int InputValue = Promt("Введи цифру дня недели: ");

if (InputValue >= 1 && InputValue <= 5) {
    Console.Write("Нет");
} else {
    Console.Write("Да");
}