using System;
using System.Diagnostics.CodeAnalysis;

class Program
{

    static void Main()
    {
        int m, n, v, max = 0, x = 0;
        Console.WriteLine("Введите промежуток чисел [m ; n] ");
        m = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
        for (v = m; v <= n; v++) 
        {
            int sum = 0, i = v;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (max < sum)
            {
                max = sum;
                x = v;
            }
        }
        Console.WriteLine("Число с максимальной суммой цифр: " + x);
        Console.ReadLine();
    }
}