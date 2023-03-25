// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrix(int m, int n, int l)
{
    int[,,] matrix = new int[m, n, l];
    List<int> list = new List<int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int rnd = UniqueInt(list);
                matrix[i, j, k] = rnd;
            }
        }
    }
    return matrix;

}

void OutputArray(int[,,] matrix, string str)
{
    System.Console.WriteLine($"{str}:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
            }
    Console.WriteLine();
    
        }
    }
}

int UniqueInt(List<int> list)
{
    int rnd = new Random().Next(10, 100);
    for (int i = 0; i < 90; i++)
    {
        if (!list.Contains(rnd))
        {
            list.Add(rnd);
            return rnd;
        }
        rnd++;

        if (rnd == 100)
            rnd = 10;
    }
    return 10;
}

System.Console.Write("Введите количество строк первого массива: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов первого массива: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество строк второго массива: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] array = CreateMatrix(a, b, c);
OutputArray(array, "Результат");