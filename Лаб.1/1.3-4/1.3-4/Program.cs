using System;


namespace _1._124
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, a1, a2, del;
            Console.WriteLine("Введите пятизначное число: ");
            a = Convert.ToInt32(Console.ReadLine());
            a1 = a / 100;
            a2 = a % 100;
            del = a1 / a2;
            Console.WriteLine("Деление: " + del);
            Console.ReadLine();

        }
    }
}

