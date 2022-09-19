int number = new Random().Next(10, 100);
System.Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit == secondDigit) System.Console.WriteLine("Цифры одинаковые");
if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа - {number} => {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа - {number} => {secondDigit}");

int maxDigit = 0;
if(firstDigit > secondDigit) maxDigit = firstDigit;
else maxDigit = secondDigit;

int max = firstDigit > secondDigit ? firstDigit : secondDigit;