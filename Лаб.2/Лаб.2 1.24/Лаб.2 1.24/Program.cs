using System;
class Program
{
    static void Main()
    {
        double x1, y1, x2, y2, x3, y3, d1, d2, d3;
        Console.WriteLine("Введите координаты первой точки: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты третьей точки: ");
        x3 = Convert.ToDouble(Console.ReadLine());
        y3 = Convert.ToDouble(Console.ReadLine());
        d1 = Math.Sqrt(x1 * x1 + y1 * y1);
        d2 = Math.Sqrt(x2 * x2 + y2 * y2);
        d3 = Math.Sqrt(x3 * x3 + y3 * y3);
        if (d1 == d2 && d2 == d3)
            Console.WriteLine("Три точки расположены на одинаковом расстоянии");
        if (d1 == d2 && d1 < d3)
        {
            Console.WriteLine($"Первая ({x1};{y1}) и вторая ({x2};{y2})  точки расположены на одинаково минимальном расстоянии от начала координат") ;
        }
        if (d1 == d3 && d1 < d2)
        {
            Console.WriteLine($"Первая ({x1};{y1}) и третья ({x3};{y3})  точки расположены на одинаково минимальном расстоянии от начала координат");
        }
        if (d3 == d2 && d2 < d1)
        {
            Console.WriteLine($"Третья ({x3};{y3}) и вторая ({x2};{y2})  точки расположены на одинаково минимальном расстоянии от начала координат");
        }
        if (d1 < d2 && d1 < d3)
        {
            Console.WriteLine("Ближе всего к началу координат расположена точка с координатами: {0} и {1}", x1, y1);
        }
        if (d2 < d3 && d2 < d1)
        {
            Console.WriteLine("Ближе всего к началу координат расположена точка с координатами: {0} и {1}", x2, y2);
        }
        if (d3 < d2 && d3 < d1)
        {
            Console.WriteLine("Ближе всего к началу координат расположена точка с координатами: {0} и {1}", x3, y3);
        }
        Console.ReadLine();
    }
}
