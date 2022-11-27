// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату x1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты первой точки - " + $"({x1}, {y1}, {z1})");
Console.WriteLine("Координаты второй точки - " + $"({x2}, {y2}, {z2})");

double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
distance = Math.Round(distance, 2);
Console.WriteLine("Расстояние между двумя точками = " + distance);