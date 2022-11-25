// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number < 6)
    {
        Console.WriteLine(number + " -> нет");
    }
    else
    {
        Console.WriteLine(number + " -> да");
    }
}
else
{
    Console.WriteLine("Неподходящее число");
}