Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int i = -number;
while(i <= number)
{
    Console.Write($" {i}, ");
    i++;
}

