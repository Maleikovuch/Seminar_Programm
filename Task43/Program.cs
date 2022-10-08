// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте первое значение для первой прямой, b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе значение для первой прямой, k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте первое значение для второй прямой, b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе значение для второй прямой, k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


double Point1(double argb1, double argk1, double argb2, double argk2)
{
    double x = (argb2 - argb1) / (argk1 - argk2);
    return x;
}

double Point2(double argb1, double argk1, double argb2, double argk2)
{
    double y = argk1 * ((argb2 - argb1) / (argk1 - argk2)) + argb1;
    return y;
}
double result1 = Point1(b1, k1, b2, k2);
double result2 = Point2(b1, k1, b2, k2);
double res1 = Math.Round(result1, 3, MidpointRounding.ToZero);
double res2 = Math.Round(result2, 2, MidpointRounding.ToZero);
Console.WriteLine($"Точка пересечения прямых -> ({res1}; {res2})");


// void Point(double argb1, double argk1, double argb2, double argk2)
// {
//     double x = (argb2 - argb1) / (argk1 - argk2);
//     double y = argk1 * ((argb2 - argb1) / (argk1 - argk2)) + argb1;
//     Console.WriteLine($"Точка пересечения прямых -> ({x}; {y})");
// }
// Point(b1, k1, b2, k2);
