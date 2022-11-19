int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number > 0)
{
    while (count <= number)
    {
        Console.Write(count + " ");
        count += 2;
    }
}
else
{
    Console.WriteLine("число не больше 0");
}