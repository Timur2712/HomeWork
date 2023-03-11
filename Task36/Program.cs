// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.WriteLine("Введите разер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] arr = new int[size];
string[] str = new string[size];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    str[i] = arr[i].ToString();
}
System.Console.WriteLine($"[{string.Join(", ", str)}]");
for (int i = 1; i < arr.Length; i +=2)
{
  sum += arr[i];
}
System.Console.WriteLine(sum);