// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 ^ number == 7)
{
    Console.WriteLine("да");
}
else if (number < 6 & number > 0)
{
    Console.WriteLine("нет");
}
else 
{
    Console.WriteLine("Введено некорректное число. Введите число от 1 до 7");
}