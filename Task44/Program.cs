Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());

void Fibonachi(int num)
{
    int num1 = 8;
    int num2 = 13;
    int num3 = default;
    Console.Write($"N = {numA} -> {num1} {num2}");
    for (int i = 2; i < num; i++)
    {
        num3 = num1 + num2;
        Console.Write($" {num3}");
        num1 = num2;
        num2 = num3;
    }
}
Fibonachi(numA);