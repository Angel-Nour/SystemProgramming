using System;


namespace _1._24
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, S, T, r1, r2, d;
            Console.Write("Введите обе скорости в км/ч: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расстояние в км: ");
            S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время пути: ");
            T = Convert.ToDouble(Console.ReadLine());
            r1 = v1 * T;
            r2 = v2 * T;
            d = r1 + r2 + S;
            Console.WriteLine("Расстояние между авто: " + d);
            Console.ReadLine();


        
        }
    }
}
