Console.WriteLine("Введите любое число чтобы увидеть его третью цифру или узнать что её нет: ");
int number = Convert.ToInt32(Console.ReadLine());
int ShowThirdDigit(int num)
{
    while (num >= 1000) num = num / 10; return num % 10;
}

int result = ShowThirdDigit(number);
Console.WriteLine(result);

