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
        Console.Write("Длина: {0}, Ширина: {1}, Высота: {2}, ", a, b, h);
    }
    public double Volume()
    {
        return a * b * h;
    }
    public double SurfaceArea()
    {
        return 2 * (a * b + a * h + b * h);
    }
}

class Program
{
   
static void Main(string[] args)
{
       
    RectParallelepiped[]arr = Create();
        RectParallelepiped rect1 = CompareMin(arr);
        Console.WriteLine("\nПараллелепипед с минимальным объемом\n ");
        rect1.Info();
        Console.WriteLine("Объем: {0}.", rect1.Volume());
        RectParallelepiped rect2 = CompareMax(arr);
        Console.WriteLine("\n\nПараллелепипед с максимальной площадью поверхности\n ");
        rect2.Info();
        Console.WriteLine("Площадь поверхности: {0}.", rect2.SurfaceArea());
    Console.ReadLine();
}
static RectParallelepiped[] Create()
{
    Console.WriteLine("\nВведите количество параллелепипидов");
    int N = Convert.ToInt32(Console.ReadLine());
    RectParallelepiped[] arr = new RectParallelepiped[N];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите стороны {0} параллелепипеда (a, b) ", i+1);
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту {0} прямоугольного параллелепипеда", i+1);
        double h = Convert.ToDouble(Console.ReadLine());
        arr[i] = new RectParallelepiped(a, b, h);
    }
    return arr;
}
    static RectParallelepiped CompareMin (RectParallelepiped[] arr)
    {
        RectParallelepiped min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (min.Volume() > arr[i].Volume())
                min = arr[i];
        }
        return min;
    }
    static RectParallelepiped CompareMax(RectParallelepiped[] arr)
    {
        RectParallelepiped max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (max.SurfaceArea() < arr[i].SurfaceArea())
                max = arr[i];
        }
        return max;
    }

}