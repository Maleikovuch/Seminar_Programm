Console.WriteLine("Введите любое число чтобы увидеть его третью цифру или узнать что её нет: ");
int number = Convert.ToInt32(Console.ReadLine());


int ShowThirdDigit(int num)
{
   if(num < 100) return -1;
   while (num >= 1000) num = num / 10;
   return num % 10;
}

int showThirdDigit = ShowThirdDigit(number);
string result = showThirdDigit < 100 ? $"Третья цифра - {showThirdDigit.ToString()}" : "Третьей цифры нет";
Console.WriteLine(result);

