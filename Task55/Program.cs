// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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


int[,] TranspornArray(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) через массив сразу меняются значения
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}

// void TranspornArray2(int[,] matrix)                      через метод менются значения с использованием временного хранилища
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             int num;
//             num = matrix[j, i];
//             matrix[j, i] = matrix[i, j];
//             matrix[i, j] = num;
//         }
//     }
// }

int[,] arr = CreateMatrixInt(6, 7, 0, 10);
PrintMatrix(arr);
Console.WriteLine();

if (arr.GetLength(0) == arr.GetLength(1))
{
    int[,] arrTrans = TranspornArray(arr);
    PrintMatrix(arrTrans);

    //  TranspornArray2(arr);
    // PrintMatrix(arr);
}
else
{
    Console.WriteLine("Массив не квадратный");
    int[,] arrTrans = TranspornArray(arr);
    PrintMatrix(arrTrans);


    // TranspornArray2(arr);
    // PrintMatrix(arr);

}



