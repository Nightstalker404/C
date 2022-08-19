// Задача 29: Напишите программу, которая задаёт массив из N элементов,
// заполненных случайными числами из [a, b) и выводит их на экран.
void RndNum(int num, int a, int b)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    Console.Write($"[{String.Join(",", arr)}]");
}
Console.Write("Введите количество элементов массива : ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон для пвсевдослучайных чисел: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
RndNum(num, a, b);