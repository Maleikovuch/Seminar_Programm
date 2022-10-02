// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SumNumbers2(int num)
// {
//     int sum = 0;
//     for (int i = 0; i < num; i++)
//     {
//         sum = sum + (num % 10);
//         num = num / 10;
//     }
//     return sum;
// }
// int sumnumbers = SumNumbers2(number);
// Console.WriteLine($"Сумма цифр в числе {number} = {sumnumbers}");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers2(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}
int sumnumbers = SumNumbers2(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumnumbers}");