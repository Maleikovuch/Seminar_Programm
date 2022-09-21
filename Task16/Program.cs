Console.WriteLine("Введите два числа чтобы узнать является ли одно число квадратом другого ");
Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

bool Square(int numA, int numB)
{
    return (numA == numB * numB) || (numB == numA * numA);
}
if (Square(a, b)) Console.WriteLine($"{a}, {b}-> Да");
else Console.WriteLine($"{a}, {b}-> Нет");

