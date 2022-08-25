// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


int[] RndNum(int num, int a, int b)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(a, b+1);
    }
    return arr;
}


int OddNum(int[] mas)
{
    int odd_count = 0;
    for (int i = 1; i < mas.Length; i += 2)
    {
        odd_count += mas[i];
    }
    return odd_count;
}

Console.Write("Введите количество элементов массива : ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон для пвсевдослучайных чисел: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int[] array = RndNum(num, a, b);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.Write(OddNum(array));
