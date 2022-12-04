// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int B = Convert.ToInt32(Console.ReadLine());

double Power = Math.Pow(A, B);
Console.WriteLine("Число " + A + " в степени " + B + " = " + Power);