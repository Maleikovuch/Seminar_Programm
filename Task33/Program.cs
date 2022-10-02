
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

bool FindElem(int[] array, int findEl)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findEl)
        {
            result = true;
            break;
        }
    }
    return result;
}

int[] arr = CreateArrayRndIntint(12, -9, 9);
PrintArray(arr);

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (FindElem(arr, num))
    Console.WriteLine("Присутствует");
else
    Console.WriteLine("Отсутствует");

