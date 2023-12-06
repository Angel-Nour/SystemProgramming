using System;
class RectParallelepiped
{
    public double a, b, h;

    public RectParallelepiped(double A, double B, double H)
    {
        a = A;
        b = B;
        h = H;
    }
    public void Info()
    {
        Console.WriteLine("Длина: {0}, Ширина: {1}, Высота: {2}", a, b, h);
    }
    public double Volume()
    {
        return a * b * h;
    }
    public double SurfaceArea()
    {
        return 2*(a * b + a * h + b * h);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите стороны основания прямоугольного параллелепипеда");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите высоту прямоугольного параллелепипеда");
        double h = double.Parse(Console.ReadLine());
        RectParallelepiped p = new RectParallelepiped(a, b, h);
        p.Info();
        Console.WriteLine("Объем параллелепипеда: " + p.Volume());
        Console.WriteLine("Площадь поверхности: " + p.SurfaceArea()); 
        Console.ReadLine();
    }
}
