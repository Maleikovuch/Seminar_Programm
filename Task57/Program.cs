// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.



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


int[] GetOneMernArray(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[index] = matrix[i, j];
            index++;
        }
    }
    return result;
}

void PrintArrayGlossary(int[] localarray)
{
    int num = localarray[0];
    int count = 1;
    for (int i = 1; i < localarray.Length; i++)
    {
        if (num == localarray[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{num} повторяется {count} раз");
            num = localarray[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} повторяется {count} раз");
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}


int[,] arr = CreateMatrixInt(7, 7, 0, 10);
PrintMatrix(arr);

int[] arr2 = GetOneMernArray(arr);
PrintArray(arr2);

Array.Sort(arr2);
PrintArrayGlossary(arr2);









