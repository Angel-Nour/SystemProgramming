using System;
class Program
{
    static void Main()
    {
        int a, x1, x2, y1, y2;
        Console.WriteLine("Введите четырехзначное число: ");
        a = Convert.ToInt32(Console.ReadLine());
        x1 = a / 1000;
        y1 = a / 100 % 10;
        y2 = a % 100 / 10;
        x2 = a % 10;
        if (x1 == x2 && y1 == y2)
            Console.WriteLine("Заданное четырёхзначное число палиндром ");
        else
            Console.WriteLine("Заданное четырёхзначное число не палиндром ");
        Console.ReadLine();
    }
}


