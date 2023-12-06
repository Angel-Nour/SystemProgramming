using System;


namespace Лаб._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, S;
            Console.WriteLine("Введите 3 стороны треугольника: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            p = (a + b + c) / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Площадь треугольника равна " + S);
                Console.ReadLine();
        }
    }
}
