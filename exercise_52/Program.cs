// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(minValue, maxValue);
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
    }
}


void AverageValue(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        average += matrix[j, i];
    Console.WriteLine(Math.Round(average / matrix.GetLength(0), 1));
    }
}


Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте диапазон случайных чисел:");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int[,] res = CreateMatrix(m, n, min, max);
PrintMatrix(res);
AverageValue(res);