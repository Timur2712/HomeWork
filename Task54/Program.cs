// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



System.Console.WriteLine("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}void ExchangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                int tmp;
                if (array[i, k] > array[i, j])
                {
                    tmp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = tmp;
                }
            }
        }
    }
}
void OutputArray(int[,] array, string str)
{
    System.Console.WriteLine($"{str}:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

    int[,] array = CreateArray(m, n);
    System.Console.WriteLine();
    OutputArray(array, "Исходный массив");
    ExchangeArray(array);
    OutputArray(array, "Конечный массив");