// Задача 5*: Напишите программу, 
// которая генерирует последовательность 
// случайных чисел из 10 элементов
//  в диапазоне от 1 до 10, 
//  и подсчитывает, сколько сгенерировалос
//   чисел больше 5.




int [] arr = new int[10];
int numQuant = 0;


for (int i=0; i<arr.Length; i++) {
    int tmp = new Random().Next(1,10);
    arr [i] = tmp;
    System.Console.WriteLine(tmp+" ");
    if (arr[i] > 5){
        numQuant += 1;
        
    }
}

System.Console.WriteLine("Количество значений больше 5 равно " + numQuant);