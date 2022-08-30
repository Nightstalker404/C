// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Point(double k1, double k2, double b1, double b2)
{
    double y1 = 0;
    double y2 = 0;
    double x = 0;
    if (k1 != k2)
    {
        x = (b2 - b1) / (k1 -k2);
        y1 = k1 * x + b1;
        y2 = k2 * x + b2;
    }
    else
    {
        Console.WriteLine("Точек пересечения нет");
    }
    Console.WriteLine($"({y1}; {y2})");
}
Console.WriteLine("Введите точку к1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку к2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку b2: ");
double b2 = double.Parse(Console.ReadLine());
Point(k1, k2, b1, b2);
