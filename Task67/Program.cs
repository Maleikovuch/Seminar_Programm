// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    result = num % 10;
    if (num != 0) result = result + SumNumbers(num / 10);
    return result;
}

SumNumbers(number);
int sum = SumNumbers(number);
Console.Write($"{sum} ");