int[] arrayGlobal = new int[123];

void FillArray(int[] array)

{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 100);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

int SumElements(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
            count++;
    }
    return count;
}

FillArray(arrayGlobal);
PrintArray(arrayGlobal);
Console.WriteLine();

int sumElements = SumElements(arrayGlobal);
Console.Write($"Количество элементов = {sumElements}");
