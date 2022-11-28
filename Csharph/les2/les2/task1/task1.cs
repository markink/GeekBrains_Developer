// . Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Promt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}


bool ValidateNumer(int number) {
    if (number >= 100 && number < 1000){
        return true;
    }
    System.Console.WriteLine("Число не трёхзначное");
    return false;
}

int numer = Promt("Введите число");
if (numer >= 100 && numer < 1000)
{
    int result = numer % 10;
    System.Console.WriteLine($"Последняя функция ввёденного числа{result}");

}
