using System;
class Program
{
    static void Main()
    {
        double x, a = 2, b = 3, k = 1, S = 1;
        Console.WriteLine("Введите x ");
        x = Convert.ToDouble(Console.ReadLine());
            while (a <= 11 && b <= 12)
        {
            S += a / b * Math.Pow(x, k);
            a++;
            b++;
            k++;
        }
        Console.WriteLine("Сумма ряда = " + S);
        Console.ReadLine();
    }
}
