using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        double x, y, z; bool t;
        Console.WriteLine("Введите стороны треугольника");
        x = Convert.ToDouble(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        z = Convert.ToDouble(Console.ReadLine());
        t = f (x, y, z);
        Console.WriteLine(t);
        static bool f (double x, double y, double z)
        {
            return (x < (y + z) && y < (x + z) && z < (x + y));
            
        }
    }
}