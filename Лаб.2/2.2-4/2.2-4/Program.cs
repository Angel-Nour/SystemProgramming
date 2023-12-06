using System;
class Program
{
    static void Main()
    {
        int a, x1, x2, x3, x4;
        Console.WriteLine("Введите четырехзначное число: ");
        a = Convert.ToInt32(Console.ReadLine());
        x1 = a / 1000;
        x2 = a / 100 % 10;
        x3 = a % 100 / 10;
        x4 = a % 10;
        if (x1 < x2 && x2 < x3 && x3 < x4)
            Console.WriteLine("Числа расположены по возрастанию");
        else
            Console.WriteLine("Числа не расположены по возрастанию");
        Console.ReadLine();
    }
}

