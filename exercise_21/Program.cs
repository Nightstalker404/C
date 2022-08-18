// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты точки А: ");
int Ax = int.Parse(Console.ReadLine());
int Ay = int.Parse(Console.ReadLine());
int Az = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B: ");
int Bx = int.Parse(Console.ReadLine());
int By = int.Parse(Console.ReadLine());
int Bz = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));
Console.Write($"Расстояние между равно: {Math.Round(distance, 2)}");