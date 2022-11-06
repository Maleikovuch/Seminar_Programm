// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[,] FindRowsMinSumElements(int[,] matrix)
{
    int[,] findRowsMinSumElements = new int[matrix.GetLength(0), 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        findRowsMinSumElements[i, 0] = sum;

    }
    return findRowsMinSumElements;
}

int ShowIndexRowsMinSum(int[,] findRowsMinSumElements)
{
    int minimum = findRowsMinSumElements[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < findRowsMinSumElements.GetLength(0); i++)
    {

        for (int j = 0; j < findRowsMinSumElements.GetLength(1); j++)
        {
            if (findRowsMinSumElements[i, j] < minimum)
            {
                minimum = findRowsMinSumElements[i, j];
                minI = i;
                minJ = j;

            }
        }
    }
    return minI+1;
}

int[,] arr = CreateMatrixInt(4, 4, 1, 9);
PrintMatrix(arr);
Console.WriteLine();

int[,] arr2 = FindRowsMinSumElements(arr);
PrintMatrix(arr2);
Console.WriteLine();

int res = ShowIndexRowsMinSum(arr2);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {res} строка. ");



