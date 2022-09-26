// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    
        factorial = factorial * i;

    return factorial;
}

