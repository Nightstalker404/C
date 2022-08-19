// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
int Extend(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i ++)
    {
        result *=  A;
    }
    return result;
}
Console.Write("Введите любое натуральное число : ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень числа А : ");
int B = int.Parse(Console.ReadLine());
Console.Write(Extend(A, B));
