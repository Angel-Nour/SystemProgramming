using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        double X, Y; int k = 2000;
        Console.WriteLine("Введите количество урожая в 2000 году: ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите количество минимального урожая: ");
        Y = Convert.ToDouble(Console.ReadLine());
        for (; X >= Y; k++)
            X -= X * 0.15;
        Console.WriteLine($" К {k} году урожай минимальный ");
        Console.ReadLine();
    }
}