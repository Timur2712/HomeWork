// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double[,] CreateOutputArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Random rnd = new Random();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10) + rnd.NextDouble();

            Console.Write($"{array[i, j]:f1}\t");
        }
        Console.WriteLine();
    }

    return array;
}
System.Console.WriteLine($" m = {m} ; n = {n}");
CreateOutputArray(m, n);


