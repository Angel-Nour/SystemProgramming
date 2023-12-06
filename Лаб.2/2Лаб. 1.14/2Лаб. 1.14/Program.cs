using System;
class Program
{
    static void Main()
    {
        int a, b, c, d1, d2;
        Console.WriteLine("Введите 3 целых положительных числа a, b и c соответственно: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d1 = b - a;
        d2 = c - b;
        if (d1 == d2)
            Console.WriteLine("Числа являются последовательно стоящими элементами арифметической прогрессии и их разность: " + d1);
        else
            Console.WriteLine("Числа не являются последовательно стоящими элементами арифметической прогрессии");
        Console.ReadLine();

    }
}


