// Задача 3: Напишите программу, 
// которая принимает на вход координаты 
// двух точек и находит 
// расстояние между ними в 2D пространстве.

int Promt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Promt("Введите x1");
int x2 = Promt("Введите x2");
int y1 = Promt("Введите y1");
int y2 = Promt("Введите y2");

int deltax = x1-x2;
int deltay = y1-y2;
double distance = Math.Sqrt(deltax*deltay);
System.Console.WriteLine(distance);

