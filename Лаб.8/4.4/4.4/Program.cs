using System;
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, P, S;
            Console.WriteLine("Введите координаты (x ; y) для первой точки прямоугольника : ");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты (x ; y) для второй точки прямоугольника: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            RectPS(x1, y1, x2, y2, out P, out S);
            Console.WriteLine("Периметр прямоугольника равен: " + P);
            Console.WriteLine("Площадь прямоугольника равная: " + S);
            Console.ReadLine();
        }

        static void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
        {
            P = 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
            S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
            return;
        }
    }
