// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Square(int num1, int num2)
{
    // int result = num1;
    // if (num2 == 0) return 1;
    // else if (num2 != 1) result = num1 * Square(num1, num2 - 1);
    // return result;

    // if (num2 == 0) return 1;                                     // сокращенный вариант
    // else return num1 = num1 * Square(num1, num2 - 1);
    
  return numb2 == 0 ? 1 : numb1 * Square (numb1, numb2-1);    
}


int resSquare = Square(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} = {resSquare}");