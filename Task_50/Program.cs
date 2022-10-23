//Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();

WriteLine("Введите размеры двумерного массива, минимальный и максимальный элемент через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] paramet = GetArrayFromString(parameters);

int[,] array = GetMatrixArray(paramet[0], paramet[1], paramet[2], paramet[3]);

WriteLine("Введите адрес ячейки массива (через пробел): ");

string[] adress = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] LineColumns = GetArrayFromString(adress);

PrintMatrix(array);
FindElement(array, LineColumns[0], LineColumns[1]);






int[] GetArrayFromString(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultMatrix;

}




void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}

void FindElement(int[,] matrix, int line, int column)
{
    int result = 0;
    if (line > matrix.GetLength(0) || column > matrix.GetLength(1)) WriteLine("Данного элемента нет в массиве, введите корректные значения");
    else WriteLine($"Искомый элемент: {matrix[line - 1, column - 1]}");
}