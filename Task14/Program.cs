Console.WriteLine("Введите число и узнаете кратно ли оно 7 и 23  ");
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

void Briefly(int numA)
{
    if (numA % 7 == 0 && numA % 23 == 0) Console.Write("Да, кратно");
    else  Console.Write("Нет, не кратно");
}
Briefly(a);