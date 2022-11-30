// Напишите программу, которая принимает 
// на вход координаты двух точек и находит
//  расстояние между ними в 3D пространстве.

int Promt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Promt("Введите x1");
int x2 = Promt("Введите x2");
int y1 = Promt("Введите y1");
int y2 = Promt("Введите y2");
int z1 = Promt("Введите z1");
int z2 = Promt("Введите z2");

int deltax = x1-x2;
int deltay = y1-y2;
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
System.Console.WriteLine(distance);