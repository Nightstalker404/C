// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] Arr(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int RndMin(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        min = arr[i];
    }
    return min;
}

int RndMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        max = arr[i];
    }
    return max;
}

Console.Write("Введите количество элементов массива : ");
int num = int.Parse(Console.ReadLine());
int[] array = Arr(num);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(RndMin(array));
Console.WriteLine(RndMax(array));

