Console.WriteLine("Введите трёхзначное число и увидете вторую цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int num)
{
    if (num < 100 || num > 999) return -1;
    int arg = num / 10;
    return arg % 10;
}
int result = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра - {result}");
