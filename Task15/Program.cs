﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Не является выходным");
        break;
    case 6:
    case 7:
        Console.WriteLine("Выходной!");
        break;
    default:
        Console.WriteLine("Такого дня недели не существует.");  
        break;          
} 
