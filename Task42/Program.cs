// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());

// void Converting(int num)
// {
//     string res = default;
//     if (num > 0)
//     {
//         if (num % 2 == 1)
//             res = res + "1";
//         else
//             res = res + "0";
//         Converting(num / 2);
//     }
//     Console.Write(res);
// }
// Converting(numA);


void Converting2(int num)
{
    string res = default;
    if (num > 0)
    {
        Converting2(num / 2);
        res += num % 2;
        
    }
    Console.Write(res);
}
Converting2(numA);