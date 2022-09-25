Console.WriteLine("Введите пятизначное число и узнаете явлется ли оно палиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());

// string Palindrome(int arg)
// {
//     int first = arg / 10000;
//     int second = (arg / 1000) % 10;
//     int fourth = (arg / 10) % 100;
//     int fifth = arg % 10;
//     if (arg < 10000 || arg > 99999) return "Ввели не корректное значение";
//     if (first == fifth || second==fourth) return "Это число является палиндромом";
//     return "Число не является палиндромом";
// }
// string result = Palindrome(num);
// Console.WriteLine(result);


// bool Palindrome(int arg)
// {
//     return (arg / 10000 == arg % 10) || ((arg / 1000) % 10==(arg / 10) % 100);
// }
// if (Palindrome(num)) Console.WriteLine($"{num}-> Палиндром");
// else if (num < 10000 || num > 99999) Console.WriteLine("Ввели не корректное значение");
// else Console.WriteLine($"{num}-> Нет, не палиндром");



void Palindrome(int arg)
{
    int first = arg / 10000;
    int second = (arg / 1000) % 10;
    int fourth = (arg / 10) % 100;
    int fifth = arg % 10;
    if (arg < 10000 || arg > 99999) Console.WriteLine("Ввели не корректное значение");
    else if (first == fifth || second==fourth) Console.WriteLine("Это число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}
Palindrome(num);