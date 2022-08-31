// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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


void PrintValue(int[,] matrix, int m, int n)
{
    try
    {
        Console.WriteLine($"{matrix[m, n]}");
    }
    catch (System.Exception)
    {
        Console.WriteLine("такого числа в массиве нет");
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
Console.WriteLine("Введите строку массива: ");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите стобец массива: ");
int n1 = int.Parse(Console.ReadLine());
PrintValue(res, m1, n1);
