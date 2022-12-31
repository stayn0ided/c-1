﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Task_68()
{
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Ackermann(m, n));
}

int Ackermann(int m, int n)
{ 
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if ((m > 0) && (n == 0))
        {
           return Ackermann(m - 1, 1);
        }
        else
        {       
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}

Task_68();
