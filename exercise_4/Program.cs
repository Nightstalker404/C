// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.Write("Введите число а: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
else if (numberB > numberC)
{
    Console.WriteLine(numberB);
}
else
{
    Console.WriteLine(numberC);
}
