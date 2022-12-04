// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
int size = 8;
int[] array = new int[size];

Random rand = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rand.Next(-20, 21);
    Console.Write(array[i] + " ");
} 
Console.WriteLine();
for (int i = 0; i < size; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < size; j++)
    {
        if(Math.Abs(array[j]) < Math.Abs(array[minPosition]))
        {
            minPosition = j;
        }
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    Console.Write(array[i] + " ");
}