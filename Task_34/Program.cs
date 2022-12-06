// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Task_34()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array, 100, 1000);
    PrintArray(array);
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine("Число четных чисел в массиве - " + count);
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

Task_34();