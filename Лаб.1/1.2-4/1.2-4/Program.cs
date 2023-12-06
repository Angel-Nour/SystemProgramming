using System;


namespace _1._124
{
    class Program
    {
        static void Main(string[] args)
        {
         double ax, ay, bx, by, cos, fi;
         Console.WriteLine("Введите координаты: ");
         ax = Convert.ToDouble(Console.ReadLine());
         ay = Convert.ToDouble(Console.ReadLine());
         bx = Convert.ToDouble(Console.ReadLine());
         by = Convert.ToDouble(Console.ReadLine());
         cos = (ax*bx + ay*by)/ ((Math.Sqrt(ax*ax + ay*ay) * Math.Sqrt(by*by + bx*bx)));
         fi = Math.Acos(cos)*180/Math.PI;
            Console.WriteLine($"Угол между векторами равен {fi} градусов");

         Console.ReadLine();

        }
    }
}



