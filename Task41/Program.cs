// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int SumEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}

int result = SumEvenElements(arr);
Console.WriteLine($"Количество чисел больше 0 -> {result}");


// Console.WriteLine("Введите количество чисел, которые хотите ввести");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int SumEvenElements(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             count++;
//     }
//     return count;

// }
// int arr = SumEvenElements(array);
// PrintArray(array);
// Console.WriteLine($"Количество элементов > 0: {arr}");