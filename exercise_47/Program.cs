// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
double[,] CreateMatrix(int m, int n, int minValue, int maxValue)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(minValue, maxValue) / 10.0;
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
    }
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте диапазон случайных чисел:");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
double[,] res = CreateMatrix(m, n, min, max);
PrintMatrix(res);
