using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        int n, S=0;
        Console.WriteLine("Введите число n: ");
        n = Convert.ToInt32(Console.ReadLine());
        for ( int k = 2*n; n<=k; n++)
            S += n * n;
        Console.WriteLine("Сумма: " + S);
        Console.ReadLine();
    }
}
