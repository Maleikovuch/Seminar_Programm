﻿Console.WriteLine("Введите любое целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number)
 {
     if (i % 2 == 0)
     Console.Write($"{i}. ");
     i++;
 }