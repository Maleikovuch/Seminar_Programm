int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 => {number}");
int DeletSecondDigit(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return firstDigit * 10 + thirdDigit;

}
int result = DeletSecondDigit(number);
Console.WriteLine($"Искомое число - {result}");
