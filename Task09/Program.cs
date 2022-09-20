int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

// if(firstDigit == secondDigit) System.Console.WriteLine("Цифры одинаковые");
// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа - {number} => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа - {number} => {secondDigit}");

// int maxDigit = 0;
// if(firstDigit > secondDigit) maxDigit = firstDigit;
// else maxDigit = secondDigit; 
// Console.WriteLine($"Наибольшая цифра числа - {number} => {maxDigit}");

// int max = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа - {number} => {max}");

// функция (метод) в функции с возвратом else не имеет смысла

int MaxDigit(int num)
{
    if (firstDigit == secondDigit) return -1;
    // if(IsEqualDigits(firstDigit, secondDigit)) return -1;

    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;

    // return firstDigit > secondDigit ? firstDigit : secondDigit;

}
// bool IsEqualDigits(int num1, int num2)
// {
//     return num1 == num2;
// }
int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString() : "Цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");








