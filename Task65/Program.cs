Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }

    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    if (num1 == num2)
    {
        Console.Write($"{num1} ");
    }
}

NaturalNumbers(number1, number2);