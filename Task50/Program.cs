// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 4;
int n = 4;

int[,] CreateOutputArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);

            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}


void SearchElementArray(int[,] initArray, int x, int y)
{


    if (x >= 0 && x < initArray.GetLength(0) && y >= 0 && y < initArray.GetLength(1))
    {
        System.Console.WriteLine(initArray[x, y]);
    }
    else
        System.Console.WriteLine("Такого значения нет");

}


System.Console.WriteLine("Введите позицию строки массива:");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию столбца массива:");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateOutputArray(m, n);
SearchElementArray(array, x, y);

