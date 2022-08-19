// Задача 27: Напишите функцию и запустите ее,
// которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());
Console.Write(SumNum(number));