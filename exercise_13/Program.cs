﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. (Строки и циклы в решении использовать нельзя!)
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
    Console.WriteLine(number / 100 % 10);
}
else
{
    Console.Write("третьей цифры нет ");
}