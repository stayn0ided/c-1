// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Task_56()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns];

    FillArray(array);
    PrintArray(array);
    minSum(array);

}

void FillArray(int[,] array)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(-10, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void minSum(int[,] array)
{
    int minSum = lineSum(array, 0);
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i + 1} = {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {minIndex + 1}");
}

int lineSum(int[,] array, int row)
{
    int sum = 0;
    int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++)
        {
           sum = sum + array[row, j];
        }
    return sum;
}

Task_56();