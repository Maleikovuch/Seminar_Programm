Console.WriteLine("Введите длину первой стороны");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
int numC = Convert.ToInt32(Console.ReadLine());

void TrialReal(int a, int b, int c)
{
    if ((a + b > c) && (a + c > b) && (c + b > a)) 
    Console.Write($"Треугольник существовать может");
    else
    Console.Write($"Треугольник не может существовать");
}

TrialReal(numA, numB, numC);