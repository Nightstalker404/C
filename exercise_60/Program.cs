// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create3DArr(int minValue, int maxValue)
{
    int[,,] matrix = new int[2, 2, 2];
    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
            for (int k = 0; k < 2; k++)
            {
                matrix[i, j, k] = new Random().Next(minValue, maxValue);
            }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            Console.WriteLine();
        }
    }
}


Console.WriteLine("Задайте диапазон случайных чисел:");
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int[,,] res = Create3DArr(min, max);
PrintMatrix(res);

