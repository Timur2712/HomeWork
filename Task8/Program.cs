﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (n >= count)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}