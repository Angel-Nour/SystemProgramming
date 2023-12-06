using System;
using System.Diagnostics.CodeAnalysis;

class Program
{

    static void Main()
    {
        int n, del;
        bool flag = true;
        Console.WriteLine("Введите натуральное число n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Простые делители числа n: ");
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                del = i;
                for (int j = 2; j < del; j++)
                {
                    if (del % j == 0)
                        flag = false;
                }
                if (flag)
                {
                    Console.WriteLine(del);
                }
                flag = true;
            }
        }
        Console.ReadLine();
    }
}