using System;

class Program
{
    static bool simple (int n)
    {

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void twins ( int lim)
    {
        for (int i = 3; i <= lim - 2; i++)
        {
            if (simple(i) && simple(i + 2))
            {
                Console.WriteLine($"{i} и {i + 2}");
            }
        }
    }

    static void Main(string[] args)
    {
        int lim = 200;

        Console.WriteLine("Числа-близнецы:");
        twins(lim);
    }
}