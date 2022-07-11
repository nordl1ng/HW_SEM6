// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите значения k1 и b1 в уравнении y = k1 * x + b1");
System.Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine()!);
System.Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите значения k2 и b2 в уравнении y = k2 * x + b2");
System.Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine()!);
System.Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine()!);
if (k1 == k2 && b1 != b2) { System.Console.WriteLine("Прямые не пересекаются - параллельны"); }
else
{
    if (k1 == k2 && b1 == b2) { System.Console.WriteLine("Прямые совпадают"); }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        System.Console.WriteLine($"Координаты точки пересечения прямых ({x} ; {y})");
    }
}