// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


using static System.Console;
Clear();


void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
    WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}





double[,] matrix = new double[3, 4];


FillArray(matrix);
WriteLine();
PrintArray(matrix);