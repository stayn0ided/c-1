// Заполните спирально массив 4 на 4 числами от 1 до 16.
void Task_58()
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];

    int start = 1;
    for (int j = 0; j < columns; j++)
    {
        array[0, j] = start;
        start++;
    }

    int start2 = 5;
    for (int i = 1; i < rows; i++)
    {
        array[i, 3] = start2;
        start2++;
    }

    int start3 = 10;
    for (int j = 0; j < columns - 1; j++)
    {
        array[3, j] = start3;
        start3--;
    }

    int start4 = 12;
    for (int i = 1; i < rows - 1; i++)
    {
        array[i, 0] = start4;
        start4--;
    }

    int start5 = 13;
    for (int j = 1; j < rows - 1; j++)
    {
        array[1, j] = start5;
        start5++;
    }

    int start6 = 16;
    for (int j = 1; j < rows - 1; j++)
    {
        array[2, j] = start6;
        start6--;
    }
    PrintArray(array);
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

Task_58();
