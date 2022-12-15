// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

void Task_47()
{
    int m = 3;
    int n = 4;
    double[,] array = new double[m, n];

    FillArray(array);
    RoundArray(array);
    PrintArray(array);
}

void FillArray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble()*20 - 10;
        }
    }
}

void PrintArray(double[,] array)
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

void RoundArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
}

Task_47();