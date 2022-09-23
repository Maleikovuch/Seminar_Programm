Console.WriteLine("Введите два числа и узнаете является ли  первое кратным второму, если нет, то увидете остаток от деления: ");
Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a % b;

// if (result == 0)
//     Console.WriteLine($"Да, первое число {a} кратно второму {b}");
// else
//     Console.WriteLine($"Нет, первое число {a} не кратно второму {b}. Остаток от деления = {result}");

void Different(int na, int nb)
{
    if ((na % nb) == 0) Console.WriteLine($"Да, число {na} кратно числу {nb}");
    else Console.WriteLine($"Нет, число {na} не кратно числу {nb}. Остаток от деления - {result}");
}
Different(a,b);