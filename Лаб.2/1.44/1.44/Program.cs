using System;
class Program
{
    static void Main()
    {
        int a, a1, a2, a3, d1, d2;
        Console.WriteLine("Введите трехзначное число: ");
        a = Convert.ToInt32(Console.ReadLine());
        a1 = a / 100;
        a2 = a % 100 / 10;
        a3 = a % 10;
        d1 = a2 - a1;
        d2 = a3 - a2;
        if (d1 == d2)
            Console.WriteLine("Числа трехзначного числа являются числами арифметической прогрессии!");
        else
            Console.WriteLine("Числа не являются последовательно стоящими элементами арифметической прогрессии");
        Console.ReadLine();
    }
}

