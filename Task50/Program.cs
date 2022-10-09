// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


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

int[,] arr = CreateMatrixInt(3, 4, 1, 9);
PrintMatrix(arr);

Console.WriteLine("Введите первую позицию элемента: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую позицию элемента: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int DisplayValue(int numA, int numB, int[,] matrix)
{
    int res = default;
    if (numA > 0 && numA < matrix.GetLength(0) + 1 && numB > 0 && numB < matrix.GetLength(1) + 1)
    {
        res = matrix[pos1 - 1, pos2 - 1];
    }
    return res;
}

int result = DisplayValue(pos1, pos2, arr);
string res = result > 0 ? $"Значение элемента  -> {result.ToString()}" : "Такого элемента в массиве нет";
Console.WriteLine($"Значение элемента: {res}");
