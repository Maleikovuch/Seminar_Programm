// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите два числа: ");
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

void Exponent(int num, int deg)
{
    int result = 1;
    if (deg > 0)
    {
        for (int i = 0; i < deg; i++)
        {
            result = result * num;
        }
        Console.WriteLine(result);
    }
    else
        Console.WriteLine("Вы ввели не корректное значение");
}
Exponent(A, B);


