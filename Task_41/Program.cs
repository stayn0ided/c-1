// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Task_41()
{
    int size = 6;
    int[] array = new int[size];
    FillArray(array, -100, 101);
    PrintArray(array);
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    Console.WriteLine("Чисел больше 0 - " + count);
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

Task_41();