// Задача 2: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void IfPointCrossing (double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2)
    {
        Console.Write("Прямые не пересекаются");
    }
    else
    {
        Console.Write($"Точка пересечения прямых: ({x}; {y})");
    }

}

int b1 = Promt("Введите число b1");
int k1 = Promt("Введите число k1");
int b2 = Promt("Введите число b2");
int k2 = Promt("Введите число k2");

IfPointCrossing (k1, b1, k2, b2);