// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine("Введите разер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
float[] arr = new float[size];
float max = float.MinValue;
float min = float.MaxValue;
string[] str = new string[size];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
    if (arr[i] > max)
        max = arr[i];
    if (min > arr[i])
        min = arr[i];
    str[i] = arr[i].ToString();
}
System.Console.WriteLine($"[{string.Join(", ", str)}]");
System.Console.WriteLine(max - min);