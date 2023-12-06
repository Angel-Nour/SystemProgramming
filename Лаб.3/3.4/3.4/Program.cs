using System;

class Program
{
    static void Main()
    {
        double x=0, max=0, S=0, Sr;
        for (int k = 1; k <= 10; k++)
        {
            Console.WriteLine($"Введите {k} оценку: ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x > max)
                max = x;
            S += x;
        }
        Sr = S / 10;
        Console.WriteLine("Среднее значение оценок: " +Sr );
        Console.WriteLine("максимальная оценка: " +max);
        Console.ReadLine();
    }
}




