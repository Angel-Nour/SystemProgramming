using System;
class Straight
{
    public double x1, y1, x2, y2;
    public Straight(double X1, double Y1, double X2, double Y2)
    {
        x1 = X1;
        y1 = Y1;
        x2 = X2;
        y2 = Y2;
    }

    public void Find ()
    {
        if (x2 == x1)
            Console.WriteLine("Уравнение прямой x = {0}", x1);
        else if (y2 == y1)
            Console.WriteLine("Уравнение прямой y = {0}", y1);
        else
        {
            if (y1 - ((y2 - y1) / (x2 - x1)) * x1 < 0)
                Console.WriteLine("Уравнение прямой y = {0}x {1}", (y2 - y1) / (x2 - x1), y1 - ((y2 - y1) / (x2 - x1)) * x1);
            else if (y1 - ((y2 - y1) / (x2 - x1)) * x1 == 0)
                Console.WriteLine("Уравнение прямой y = {0}x", (y2 - y1) / (x2 - x1));
            else
                Console.WriteLine("Уравнение прямой y = {0}x + {1}", (y2 - y1) / (x2 - x1), y1 - ((y2 - y1) / (x2 - x1)) * x1);
        }
    }
    public void Info ()
    {
        Console.WriteLine("Прямая проходящая через точки: ({0};{1}) и ({2};{3}) ", x1, y1, x2, y2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты (x,y) первой точки");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты (x,y) второй точки");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        Straight l1 = new Straight(x1, y1, x2, y2);
        l1.Info();
        l1.Find();
        Console.ReadLine();
    }
}