// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("Х: ");
int argAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int argAY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int argAZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int argBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int argBY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int argBZ = Convert.ToInt32(Console.ReadLine());


double LenghLine(int ax, int ay, int az, int bx, int by, int bz)
{
    int x = bx - ax;
    int y = by - ay;
    int z = bz - az;
    return Math.Sqrt(x * x + y * y + z * z);
}
double lenghLine = LenghLine(argAX, argAY, argAZ, argBX, argBY, argBZ);
double lenght = Math.Round(lenghLine, 2, MidpointRounding.ToZero);
Console.WriteLine($"A({argAX}, {argAY}, {argAZ}); B ({argBX}, {argBY},{argBZ})  -> {lenght}");
