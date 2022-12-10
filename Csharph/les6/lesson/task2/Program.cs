// Напишите программу, 
// которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник 
// с сторонами такой длины.


int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckTriangle (int value1, int value2, int value3) {
    if (value1+value2>value3) {
        return true;
    }
    return false;
}


int value1 = Promt("Введите первую сторону треугольника: ");
int value2 = Promt("Введите вторую сторону треугольника: ");
int value3 = Promt("Введите третью сторону треугольника: ");

if (CheckTriangle (value1, value2, value3) && CheckTriangle (value1, value3,  value2) && CheckTriangle (value3, value2, value1)) {
    System.Console.WriteLine("Такой треугольник может существовать");

} else {
    System.Console.WriteLine("Такой треугольник ne может существовать");
}