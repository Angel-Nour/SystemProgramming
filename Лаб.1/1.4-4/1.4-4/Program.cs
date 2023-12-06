using System;


namespace _1._144
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, S, n;
            Console.WriteLine("Введите значение радиуса окружности R: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во углов фигуры висанной в окружность: ");
            n = Convert.ToDouble(Console.ReadLine());
            S = n / 2 * (R * R) * Math.Sin((2 * Math.PI) / n);
            Console.WriteLine($"Площадь правильного n-угольника, вписанного в окружность радиуса {R:0.00}, равна {S:0.00}");
            Console.ReadLine();
        }
    }
}



