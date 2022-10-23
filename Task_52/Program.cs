//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

// Например, задан массив:
//   1 4 7 2
//   5 9 2 3
//   8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Console;
Clear();
Write("Введите количество строк и столбцов матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);


PrintMatrix(matrix);

ArithmeticMean(matrix);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)

{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = new Random().Next(minValue, maxValue+1);
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
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    } 
}



int[] GetArrayFromString(string parameters)

{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }

    return parameterNum;
}


void ArithmeticMean(int[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double average = 0;
        int sum = 0; 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            average = sum / array.GetLength(1);
            average = Math.Round(average, 1);
        }
        Write($"Среднее арифметическое каждого столбца: {average}; ");
    }
}