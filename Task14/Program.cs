Console.WriteLine("Введите число и узнаете кратно ли оно 7 и 23  ");
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
// int result = a % b;

string Briefly(int numA)
{
    if (numA % 7 == 0 && numA % 23 == 0) return $"Да, кратно";
    else return $"Нет, не кратно";
}
string result = Briefly(a);
Console.WriteLine(result);