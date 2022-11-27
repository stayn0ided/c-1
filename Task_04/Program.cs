int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());
int numberThird = Convert.ToInt32(Console.ReadLine());
int max = numberFirst;
if (numberSecond > max)
{
    max = numberSecond;
}
if (numberThird > max)
{
    max = numberThird;
}
Console.WriteLine(max);