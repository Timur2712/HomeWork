﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    System.Console.WriteLine("Введите количество столбцов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество строк массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateOutputArray(int m, int n)
{


    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);

            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
        System.Console.WriteLine("Среднее арифметическое столбцов:");
    return array;
}

int[,] SearchAverageArray(int[,] initArray)
{
    for (int i = 0; i < initArray.GetLength(1); i++)
    {
        float sum = 0;
        for (int j = 0; j < initArray.GetLength(0); j++)
        {
            sum += initArray[j, i];
        }
        float avr = sum / initArray.GetLength(0);
        System.Console.Write(avr + "\t");
    }
    return initArray;
}

SearchAverageArray(CreateOutputArray(m, n));