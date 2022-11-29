// Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает
// что третьей цифры нет. . Не использовать строки

int Promt(string message)
{
    System.Console.Write($"{message}");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int InputValue = Promt("Введите число: ");

int arrayIndex = 1;

int Condition = InputValue;
int InputValue1 = InputValue;

while (Condition >= 10)
{
    Condition = Condition / 10;
    arrayIndex = arrayIndex + 1;
}

int [] array = new int [arrayIndex];

for (int i=0; i<array.Length; i++){
    array [i] = InputValue1%10;
    InputValue1 = InputValue1/10;
}

Array.Reverse(array);

if (InputValue < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третьей цифрa: " + array[2]);
}