//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int SecondNumber = (number / 10) % 10;
    Console.WriteLine("Вторая цифра числа - " + SecondNumber);
}
else
{
    Console.WriteLine("Число не трехзначное");
}