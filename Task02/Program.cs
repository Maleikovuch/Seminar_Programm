Console.WriteLine("Введите два целых числа и вы увидете какое число меньшее, а какое число большее! ");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (b > max)
{
    Console.WriteLine($"Большее число - {b}");
    Console.WriteLine($"Меньшее число - {a}");
}
else
{
    Console.WriteLine($"Большее число - {a}");
    Console.WriteLine($"Меньшее число - {b}");
}
    