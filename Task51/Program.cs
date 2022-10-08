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

int SumElementsDiagonalInt(int[,] matrix)
{
    int sum = default;
    int count = matrix.GetLength(0) > matrix.GetLength(1) ? 1 : 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}


int[,] array2D = CreateMatrixInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();

SumElementsDiagonalInt(array2D);
int result = SumElementsDiagonalInt(array2D);
Console.WriteLine(result);