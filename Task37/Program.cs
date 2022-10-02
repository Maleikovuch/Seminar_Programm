int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = { 6, 7, 3, 6 };

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}


int[] Mult(int[] array)
{
    int length = array.Length;
    int size = length / 2;
    if (length % 2 == 1)
    {
        size++;
    }

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[(length - 1) - i];
    }

    if (length % 2 == 1)
    {
        result[size - 1] = array[size - 1];
    }
    return result;
}

PrintArray(array1);
Console.WriteLine();

int[] reault1 = Mult(array1);
PrintArray(reault1);
Console.WriteLine();


PrintArray(array2);
Console.WriteLine();

int[] reault2 = Mult(array2);
PrintArray(reault2);


