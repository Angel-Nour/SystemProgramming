using System;

namespace Лаб._1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sin, cos;
            Console.WriteLine("Введите значение угла альфа в градусах: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Math.PI * a / 180;
            sin = Math.Sin(b);
            cos = Math.Cos(b);
            Console.WriteLine("Синус угла альфа равен " + sin);
            Console.WriteLine("Косинус угла альфа равен " + cos);
                Console.ReadLine();
        }
    }
}
