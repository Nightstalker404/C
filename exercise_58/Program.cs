// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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


int[,] ProductMatrix(int[,] matrix, int[,] matrix1, int m, int n)
{
    int[,] res_matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                res_matrix[i, j] += matrix[i, k] * matrix1[k, j];
            }
    }
    return res_matrix;
}


Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте диапазон случайных чисел:");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int[,] res = CreateMatrix(m, n, min, max);
int[,] res1 = CreateMatrix(m, n, min, max);
Console.WriteLine("Первая матрица:");
PrintMatrix(res);
Console.WriteLine("Вторая матрица:");
PrintMatrix(res1);
int[,] res_matrix = ProductMatrix(res, res1, m, n);
Console.WriteLine("Произведение двух матриц:");
PrintMatrix(res_matrix);
