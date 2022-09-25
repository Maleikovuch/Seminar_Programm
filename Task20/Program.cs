Console.WriteLine("Введите координаты первой точки: ");
Console.Write("Х: ");
int argAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int argAY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int argBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int argBY = Convert.ToInt32(Console.ReadLine());

// int argX = argBX - argAX;
// int argY = argBY - argAY;

// double argZ = Math.Sqrt(argX*argX + argY*argY);

// Console.WriteLine($"-> {argZ}");

double LenghLine(int ax, int ay, int bx, int by)
{
    int x = bx - ax;
    int y = by - ay;
    return Math.Sqrt(x * x + y * y);
}
double lenghLine = LenghLine(argAX, argAY, argBX, argBY);
double lenght = Math.Round(lenghLine, 2, MidpointRounding.ToZero);
Console.WriteLine($"A({argAX}, {argAY}); B ({argBX}, {argBY})->{lenght}");
