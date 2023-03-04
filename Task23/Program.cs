// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(1);
for (int i = 2; i <= num; i++)
{
    double pow3 = Math.Pow(i, 3);
    Console.Write($", {pow3:f0}");
}