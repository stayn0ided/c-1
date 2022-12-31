//  Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

void Task_64()
{
    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    

    FindNumbers(N, M);
}

void FindNumbers(int number, int counter)
{ 
    if (counter > number) return;
    if (counter % 3 == 0)
    {
        Console.Write($"{counter}\t");
    }
    counter++;
    FindNumbers(number, counter);
}

Task_64();

