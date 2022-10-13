// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int num1, int num2)
{
    int sum = num1;
    if (num1 < num2)
        return sum = sum + SumNaturalNumbers(num1 + 1, num2);
    else if (num1 > num2) return sum = sum + SumNaturalNumbers(num1 - 1, num2);
    else return sum;
}

int sumNaturalNumbers = SumNaturalNumbers(number1, number2);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {number1} до {number2} -> {sumNaturalNumbers}");
