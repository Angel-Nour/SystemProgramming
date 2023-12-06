using System;


namespace _1._114
{
    class Program
    {
        static void Main(string[] args)
        {
        double v, t, h, g;
        Console.Write("Введите скорость подброшенного тела: ");
        v = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите момент времени: ");
        t = Convert.ToDouble(Console.ReadLine());
        g = 9.81;
        h =v*t-(g*Math.Pow(t, 2)/ 2);
        Console.WriteLine("Высота тела в момент t равна " + h);
        Console.ReadLine();


        }
    }
}



