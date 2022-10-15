// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixIntFirst(int rows, int columns, int min, int max)
{
    int[,] matrixFirst = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            matrixFirst[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixFirst;

}

void PrintMatrixFirst(int[,] matrixFirst)
{

    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            if (j < matrixFirst.GetLength(1) - 1) Console.Write($"{matrixFirst[i, j],4} ");
            else Console.Write($"{matrixFirst[i, j],4}");
        }
        Console.WriteLine(" ");
    }

}

int[,] CreateMatrixIntSecond(int rows, int columns, int min, int max)
{
    int[,] matrixSecond = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            matrixSecond[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixSecond;

}

void PrintMatrixSecond(int[,] matrixSecond)
{

    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            if (j < matrixSecond.GetLength(1) - 1) Console.Write($"{matrixSecond[i, j],4} ");
            else Console.Write($"{matrixSecond[i, j],4}");
        }
        Console.WriteLine(" ");
    }

}

int[,] MultiplicationMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] multi = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                if (matrixFirst.GetLength(1) == matrixSecond.GetLength(0))
                    multi[i, j] = multi[i, j] + matrixFirst[i, k] * matrixSecond[k, j];

            }
        }
    }
    return multi;

}

void PrintMatrixMulti(int[,] multi)
{

    for (int i = 0; i < multi.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            if (j < multi.GetLength(1) - 1) Console.Write($"{multi[i, j],4} ");
            else Console.Write($"{multi[i, j],4}");
        }
        Console.WriteLine(" ");
    }

}



int[,] arr = CreateMatrixIntFirst(2, 2, 2, 4);
PrintMatrixFirst(arr);
Console.WriteLine("X");

int[,] arr2 = CreateMatrixIntSecond(2, 2, 2, 4);
PrintMatrixSecond(arr2);
Console.WriteLine(" ____________");

int[,] arr3 = MultiplicationMatrix(arr, arr2);
PrintMatrixMulti(arr3);
