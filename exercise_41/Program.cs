// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Arr(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число:");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int PositiveSum(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++) 
    {
        if (mas[i] > 0)
            count += 1;

    }
    return count;
}

Console.WriteLine("Введите количество символов массива: ");
int num = int.Parse(Console.ReadLine());
int[] arr = Arr(num);
Console.WriteLine($"[{String.Join(" ", arr)}]");
Console.WriteLine($"Количество положительных чисел массива: {PositiveSum(arr)}");
