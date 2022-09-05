// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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


//for run in range(n - 1):
//    for i in range(len(lst)):
//        for j in range(len(lst[i]) - 1):
//            if lst[i][j] > lst[i][j + 1]:
//                lst[i][j], lst[i][j + 1] = lst[i][j + 1], lst[i][j]
//
int[,] SortByMax(int[,] matrix)
{
    for (int run = 0; run < matrix.GetLength(1) - 1; run++)
    {
        int max = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) -1 ; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    max = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = max;
                }
            }
        }

    }
    return matrix;
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
Console.WriteLine();
int[,] sorted = SortByMax(res);
PrintMatrix(sorted);