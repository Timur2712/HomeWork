// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите числа через запятую или пробел: ");
string? str = Console.ReadLine();
char[] divs = {' ', ','};
string [] g = str.Split(divs, StringSplitOptions.RemoveEmptyEntries);
int count = 0;

for (int i = 0; i < g.Length; i++)
{
    int nums = Convert.ToInt32(g[i]);
    if (nums > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Положительных чисел {count}");