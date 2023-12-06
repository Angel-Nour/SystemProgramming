using System;
class Program
{
    static long ProdR(long n)
    {
        if (n < 10)
            return n;
        else
        return n % 10 * ProdR(n / 10);
    }
        static void Main(string[] args)
    {
        Console.Write("Введите натуральное n= ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Произведение цифр числа через рекурсию: " + ProdR(n));
        Console.WriteLine("Произведение цифр числа: " + Prod(n));
        Console.ReadLine();
    }

    static long Prod(long n)
    {
        long prod = 1;
        while (n > 0)
        {
            prod *= n % 10;
            n /= 10;
        }
        return prod;
    }
}