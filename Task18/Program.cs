Console.WriteLine("Введите номер четверти:");
string number = Console.ReadLine();

string Quarter(string num)
{
    string phrase = "Данной четверти соответствуют координаты, где";
    if (num == "1") return $"{phrase} X > 0 и Y > 0";
    if (num == "2") return $"{phrase} X < 0 и Y > 0";
    if (num == "3") return $"{phrase} X < 0 и Y < 0";
    if (num == "4") return $"{phrase} X > 0 и Y < 0";
    return "Ведены неверные значения";
}
string result = Quarter(number);
Console.WriteLine(result);



