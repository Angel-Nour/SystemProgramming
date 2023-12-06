using System;
class Program
{
    static void Main()
    {
        int a1, a2, a3, a4, c=0;
        Console.WriteLine("Введите 4 целых числа:");
        a1 = Convert.ToInt32(Console.ReadLine());
        a2 = Convert.ToInt32(Console.ReadLine());
        a3 = Convert.ToInt32(Console.ReadLine());
        a4 = Convert.ToInt32(Console.ReadLine());
        if (a1 % 2 == 0)
            c++;
        if (a2 % 2 == 0)
            c++;
        if (a3 % 2 == 0)
            c++;
        if (a4 % 2 == 0)
            c++;
        Console.WriteLine("Всего четных чисел: " + c );
        Console.ReadLine();
    }
}


