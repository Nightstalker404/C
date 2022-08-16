// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Write("Введите число от 100 до 999: ");
int number = int.Parse(Console.ReadLine());
if (number > 99 & number < 1000)
{
    Console.WriteLine(number / 10 % 10);
}
else
{
    Console.WriteLine("Введено некорректное число");
}

