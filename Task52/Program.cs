// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




int[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;

}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ");
    }

}


double[] FindAverageElementsColumns(int[,] matrix)
{
    double[] findAverageElementsColumns = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        findAverageElementsColumns[j] = Math.Round(sum / matrix.GetLength(0), 1, MidpointRounding.ToZero);
    }
    return findAverageElementsColumns;
}

void PrintArray(double[] findAverageElementsColumns)
{
    Console.Write(" ");
    for (int i = 0; i < findAverageElementsColumns.Length - 1; i++)
        Console.Write($"{findAverageElementsColumns[i]};  ");
    Console.Write($"{findAverageElementsColumns[findAverageElementsColumns.Length - 1]}");

}



int[,] arr = CreateMatrixInt(3, 4, 1, 9);
PrintMatrix(arr);

double[] arr2 = FindAverageElementsColumns(arr);

PrintArray(arr2);



