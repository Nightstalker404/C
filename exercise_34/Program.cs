// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RndNum(int num, int a, int b)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(a, b+1);
    }
    return arr;
}


int EvenNum(int[] mas)
{
    int even_count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            even_count++;
        }
    }
    return even_count;
}

Console.Write("Введите количество элементов массива : ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон для пвсевдослучайных чисел: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int[] array = RndNum(num, a, b);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.Write(EvenNum(array));