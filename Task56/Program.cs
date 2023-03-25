// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
}

void SumArray(int[,] array)
{
    int minLine = 0;
        int min = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = SumLine(array, i);

        System.Console.WriteLine($"В {i + 1} строке сумма элементов {sum}");

        if (min > sum)
        {
            min = sum;
            minLine = i;
        }
    }
        System.Console.WriteLine($"В {minLine + 1} строке находится минимальное значение {min}");
}
int SumLine(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

void OutputArray(int[,] array)
{

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
OutputArray(array);
System.Console.WriteLine();
SumArray(array);


