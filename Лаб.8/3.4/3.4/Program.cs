using System;
class Program
{
    static void Main()
    {
        int a, b, c, d, x, y, n;
        Console.WriteLine("Введите числитель и знаменатель первой дроби: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите числитель и знаменатель второй дроби: ");
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());
        x = a * c;
        y = b * d;
        n = NOD (x, y);
        x /= n;
        y /= n;
        Console.WriteLine("Сокращенная дробь: {0} / {1}", x, y);
        Console.ReadLine();
    }
    static int NOD (int a, int b)
    {
        while (a != 0 &&  b != 0)
        {
            if (a > b)
            {
                a = a % b;
            }
            else
            {
                b = b % a;
            }
        }
        return a + b;
       
    }
}