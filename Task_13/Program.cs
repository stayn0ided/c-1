// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 > 0)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine("Третья цифра числа - " + number);
}
else
{
    Console.WriteLine("В числе меньше трех цифр");
}