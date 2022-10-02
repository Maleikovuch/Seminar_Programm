// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arrayGlobal = new int[8];
FillArray(arrayGlobal);
PrintArray(arrayGlobal);

void FillArray(int[] array)

{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 2);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++) 
    Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length-1]}]");
}
