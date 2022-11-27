// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int copy = number;
int result = 0;
if (number > 9999 && number < 100000)
{
    while (copy > 0)
    {
        int digit = copy % 10;
        result = result * 10 + digit;
        copy = copy / 10;
    }
    if (number == result)
    {
        Console.WriteLine("Введенное число - палиндром");
    }
    else
    {
        Console.WriteLine("Введенное число не палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}