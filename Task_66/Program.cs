//  Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.

void Task_66()
{
    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());

    FindSum(N, M);
}

void FindSum(int number, int counter, int sum = 0)
{ 
    if (counter > number) 
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + counter;
    counter++;
    FindSum(number, counter, sum);
}

Task_66();
