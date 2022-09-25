Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    int count = 1;
    if (count > 0)
    {
        while (count <= a)
        {
            Console.WriteLine($"{count}   {Math.Pow((count), 3),3}");
            count++;
        }
    }
    else
    {
        Console.WriteLine("Ввели не корректное значение");
    }
}
Square(a);


