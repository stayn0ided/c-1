// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void Task_50()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns];

    FillArray(array);
    PrintArray(array);

    Console.WriteLine("Введите номер строки элемента");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца элемента");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m < (rows + 1) && n < (columns + 1))
    {
        Console.Write($"Значение элемента [{m}, {n}] - {array[m - 1, n - 1]}");
    }

    else
    {
        Console.Write("Нет такого элемента");
    }
}

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Task_50();