using System;
class Program
{
    static void Main()
    {
        double a1, b1, a2, b2;
        Console.WriteLine("Введите длину и ширину конверта соответственно: ");
        a1 = Convert.ToDouble(Console.ReadLine());
        b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите длину и ширину открытки соответственно: ");
        a2 = Convert.ToDouble(Console.ReadLine());
        b2 = Convert.ToDouble(Console.ReadLine());
        if (a1 > a2 && b1 > b2 || a1 > b2 && b1 > a2 )
            Console.WriteLine("Открытка поместится в конверт");
        else
        Console.WriteLine("Открытка не поместится в конверт");
        Console.ReadLine();
    }
}
