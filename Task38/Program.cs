// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateNewArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min; 
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferenceMaxMin(double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        dif = max - min;
    }
    return dif;
}

double[] arr = CreateNewArrayRndDouble(10, 10, 100);
PrintArray(arr);

double diffMaxMin = DifferenceMaxMin(arr);
double difMX = Math.Round(diffMaxMin, 1, MidpointRounding.ToZero);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {difMX}");

