Console.WriteLine("Введите два числа и вы узнаете является ли первое число квадратом второго!");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int squaerb = b * b;
if (squaerb == a)
{
    Console.WriteLine($"Верно, первое число {a} является квадратом второго числа {b} ");
}
else
{
Console.WriteLine($"Неверно, первое число {a} не является квадратом второго числа {b} ");
}