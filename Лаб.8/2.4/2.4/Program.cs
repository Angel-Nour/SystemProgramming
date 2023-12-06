using System;

class Program

{
    static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, S;
            Console.WriteLine("Введите координаты 1 вершины:");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты 2 вершины:");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты 3 вершины:");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты 4 вершины:");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты 5 вершины:");
            x5 = Convert.ToInt32(Console.ReadLine());
            y5 = Convert.ToInt32(Console.ReadLine());
            S = Square(x1, y1, x2, y2, x3, y3) + Square(x1, y1, x3, y3, x4, y4) + Square(x1, y1, x4, y4, x5, y5);
            Console.WriteLine("Площадь пятиугольника: " + S);
        }
        static double Square(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a, b, c, p, S;
            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            c = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
     
    }