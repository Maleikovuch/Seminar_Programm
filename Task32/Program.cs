﻿
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

void Inverse (int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
      array[i] = -array[i];  
    }
    
}

int[] arr = CreateArrayRndIntint(12, -9, 9);
PrintArray(arr);

Inverse(arr);
PrintArray(arr);
