using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        int n, k=0;
        Console.WriteLine("Введите натуральное число n:");
        n = Convert.ToInt32(Console.ReadLine());
        for (; n > 1; k++)
        {
            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n = n * 3 + 1;
            }
            Console.WriteLine(n);
        }
        Console.WriteLine($"Последовательность достигает до 1 за {k} шагов ");
        Console.ReadLine();
    }
}
