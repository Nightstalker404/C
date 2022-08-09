// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
Console.Write("Введите число а: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
else
{
    Console.WriteLine($"max = {numberB}");
}
