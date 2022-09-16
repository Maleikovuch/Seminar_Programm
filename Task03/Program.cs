Console.WriteLine("Введите целое число от 1 до 7 и увидете какой день недели!");
// int number = Convert.ToInt32(Console.ReadLine());

// 1.Вариант

// switch (number)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота"); break;
//     case 7: Console.WriteLine("Воскресенье"); break;
// }

// 2.Вариант

// if (number > 7 || number < 1)
// {
//     Console.WriteLine("В неделе 7 дней");
// }
// if (number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// if (number == 2)
// {
//     Console.WriteLine("Среда");
// }
// if (number == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if (number == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if (number == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if (number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// if (number==1)
// {
//     Console.WriteLine("Понедельник");
// }

// 3. Вариант

string number = Console.ReadLine();
if (number == "1")
{
    Console.WriteLine("Понедельник");
}
else if (number == "2")
{
    Console.WriteLine("Вторник");
}
else if (number == "3")
{
    Console.WriteLine("Среда");
}
else if (number == "4")
{
    Console.WriteLine("Четверг");
}
else if (number == "5")
{
    Console.WriteLine("Пятница");
}
else if (number == "6")
{
    Console.WriteLine("Суббота");
}
else if (number == "7")
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("В неделе 7 дней");
}