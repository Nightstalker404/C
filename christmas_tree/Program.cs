// Задача “со звездочкой”: (необязательное) Напишите функцию, которая принимает одно число - высоту елочки
// и рисует ее в консоли звездочками.
void Tree(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{string.Concat(Enumerable.Repeat(" " , num - i))}{string.Concat(Enumerable.Repeat("*" , i+count))}");
    count += 1;
    }
}
Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());
Tree(number);