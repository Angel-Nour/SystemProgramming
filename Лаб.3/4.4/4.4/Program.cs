using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        int x, Sn=0, Sz=0, n;
        Console.WriteLine("Введите натуральное число: ");
        x = Convert.ToInt32(Console.ReadLine());
        while (x > 0)
        {
            n = x % 10;
            if (n % 2 == 0)
                Sz += n;
            else
                Sn += n;
            x = x / 10;
        }
        Console.WriteLine("Сумма четных чисел: " + Sz);
        Console.WriteLine("Сумма нечетных чисел: " + Sn);
        Console.ReadLine();
    }
}





