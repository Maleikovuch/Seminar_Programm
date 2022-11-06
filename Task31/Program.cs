
int[] CreateArrayRndIntint(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetSumPosNegElem(int[] array)
{
    int sumPos = default;
    int sumNeg = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
        else sumPos += array[i];
    }
    return new int[] { sumPos, sumNeg };
}

// int GetSumPosElem(int[] array)
// {
//     int sumPos = default;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) sumPos += array[i];
//     return sumPos;
// }
// int GetSumNegElem(int[] array)
// {
//     int sumNeg = default;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < 0) sumNeg += array[i];
//     return sumNeg;
// }

int[] arr = CreateArrayRndIntint(12, -9, 9);
PrintArray(arr);
// int sumPositive = GetSumPosElem(arr);
// int sumNegative = GetSumNegElem(arr);
// Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");

int[] SumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine($"Сумма положительных элементов = {SumPosNegElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {SumPosNegElem[1]}");







// int[] arrayGlobal = new int[12];

// void FillArray(int[] array)

// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(-9, 9);
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length-1; i++) 
//     Console.Write($"{array[i]}, ");
//     Console.Write($"{array[array.Length-1]}]");
// }

// int GetSumPosElem(int[] array)
// {
//     int sumPos = default;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) sumPos += array[i];
//     return sumPos;
// }
// int GetSumNegElem(int[] array)
// {
//     int sumNeg = default;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < 0) sumNeg += array[i];
//     return sumNeg;
// }


// FillArray(arrayGlobal);
// PrintArray(arrayGlobal);
// Console.WriteLine();
// int sumPositive=GetSumPosElem(arrayGlobal);
// int sumNegative = GetSumNegElem(arrayGlobal);
// Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");
