// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите перове число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if (m == n)
        return m;
    return m + SumNumbers(m + 1, n);

}
System.Console.WriteLine($"Сумма натуральных чисел в диапозоне от {m} до {n} равна {SumNumbers(m, n)}");