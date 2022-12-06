// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Task_38()
{
int size = 6;
double[] array = new double[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(rand.NextDouble() * 10, 2);
} 

PrintArray(array);

double minValue = array[0];
double maxValue = array[0];

for (int i = 1; i < size; i++)
{
    if (minValue > array[i])
    {
        minValue = array[i];
    }
}
for (int i = 1; i < size; i++)
{
    if (maxValue < array[i])
    {
        maxValue = array[i];
    }
}
Console.WriteLine("Максимальное значение - " + maxValue);
Console.WriteLine("Минимальное значение - " + minValue);

double diff = maxValue - minValue;

Console.WriteLine("Разница - " + diff);
}

void PrintArray(double[] nums)
{
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}

Task_38();