// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите количество чисел");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 1; i < n + 1; i++)
{
    System.Console.WriteLine($"Введите число № {i}: ");
    array[i - 1] = int.Parse(Console.ReadLine()!);
}
int summ = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        summ++;
    }
}
System.Console.WriteLine($"Количество положительных чисел равно: {summ}");