
using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        int x, k = 1, i = 1;
        Console.WriteLine("Введите натуральное число: ");
        x = Convert.ToInt32(Console.ReadLine());
        while (k < x)
        {
            k = k * (i + 1);
            i++;
        }

        if (k == x)
            Console.WriteLine($"Факториал числа {i} ");
        else
            Console.WriteLine("Введенное число не является факториалом");

        Console.ReadLine();
    }
}
