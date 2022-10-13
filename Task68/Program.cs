// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Akkerman(int num1, int num2)
{
    int result = default;
    if (num1 == 0) return result = num2 + 1;
    else if (num1 > 0 && num2 == 0) return result = Akkerman(num1 - 1, 1);
    else if (num1 > 0 && num2 > 0) return result = Akkerman(num1 - 1, Akkerman(num1, num2-1));
    else return result;
}

int akkerman = Akkerman(number1, number2);
Console.WriteLine($"Функция Аккермана от чисел {number1}, {number2} -> {akkerman}");
