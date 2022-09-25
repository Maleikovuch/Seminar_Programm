// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели и узнаете явялется ли этот день выходным: ");
int number = Convert.ToInt32(Console.ReadLine());

void Week(int num)
{
    if (number < 1 || number > 7)  Console.WriteLine("Такого дня недели не существует");
    else if (number == 6 || number == 7) Console.WriteLine("Этот день выходной"); 
    else Console.WriteLine("Этот день не выходной");
}
Week(number);

// switch (number)
// {
//     case <1: Console.WriteLine("Такого дня недели не существует"); break;
//     case >8: Console.WriteLine("Такого дня недели не существует"); break;
//     case 1: Console.WriteLine("Этот день не выходной"); break;
//     case 2: Console.WriteLine("Этот день не выходной"); break;
//     case 3: Console.WriteLine("Этот день не выходной"); break;
//     case 4: Console.WriteLine("Этот день не выходной"); break;
//     case 5: Console.WriteLine("Этот день не выходной"); break;
//     case 6: Console.WriteLine("Этот день не выходной"); break;
//     case 7: Console.WriteLine("Этот день выходной"); break;
//     case 8: Console.WriteLine("Этот день выходной"); break;
//     }


