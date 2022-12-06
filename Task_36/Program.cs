// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Task_36()
{
    int size = 7;
    int[] array = new int[size];
    FillArray(array, -10, 11);
    PrintArray(array);
    int count = 0;
    for (int i = 1; i < size; i = i + 2)
    {
        count += array[i];
    }
    Console.WriteLine("Сумма элементов с нечетными индексами - " + count);
}

void FillArray(int[] nums, int minValue, int maxValue)
{
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)
{
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

Task_36();