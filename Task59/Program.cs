// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.




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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("  |");
    }

}


int[] IndexMinMax(int[,] matrix)
{
    int min = matrix[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }

    }
    return new int[] { minI, minJ };
}

int[,] DeletMinMaxRosColumns(int[,] matrix, int[] indexIJ)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int resultI = 0;
    int resultJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != indexIJ[0])
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != indexIJ[1])
                {
                    result[resultI, resultJ] = matrix[i, j];
                    resultJ++;
                }
            }
            resultI++;
            resultJ=0;
        }


    }
    return result;
}


int[,] arr = CreateMatrixInt(6, 7, 0, 10);
PrintMatrix(arr);
Console.WriteLine();

int[] arr3 = IndexMinMax(arr);

int[,] arr2 = DeletMinMaxRosColumns(arr, arr3);
PrintMatrix(arr2);



