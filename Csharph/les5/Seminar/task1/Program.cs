void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($"{array[rows, columns]} ");
        }
        System.Console.WriteLine();
    }
}


void FillArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = new Random().Next(1,10);
        }        
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);



// for (int rows = 0; rows < matrix.GetLength(0); rows++)
// {
//     for (int columns = 0; columns < matrix.GetLength(1); columns++ ){
//         Console.Write($"{matrix[rows, columns]} ");
//     }
//     System.Console.WriteLine();
// }