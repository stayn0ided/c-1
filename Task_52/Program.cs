// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Task_52()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns];

    FillArray(array);
    PrintArray(array);
    ColumnMean(array);
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

void ColumnMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            count++;
        }
        Console.WriteLine($"Среднее арифметическое элементов столбца {j + 1} = {Math.Round(sum / count, 2)}");
    }
}

Task_52();