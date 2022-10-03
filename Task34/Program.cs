
int[] CreateNewArrayInt(int size, int min, int max)
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

int FindEvenNumbers(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}

int[] arr = CreateNewArrayInt(10, 100, 1000);
PrintArray(arr);

int sumEvenNumbers = FindEvenNumbers(arr);
Console.WriteLine($"Количество четных чисел в массиве = {sumEvenNumbers}");