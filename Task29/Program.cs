// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] arrayGlobal = new int[8];
FillArray(arrayGlobal);
PrintArray(arrayGlobal);

void FillArray(int[] array)

{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 100);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++) 
    Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length-1]}]");
}
