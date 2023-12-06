using System;
class Program
{
    static void Main()
    {
        int m, n, max = 0, min = 0;
        Console.WriteLine("Введите количество строк");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        n = Convert.ToInt32(Console.ReadLine());
        int[,] matr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Введите элементы {0}-й строки", i + 1);
            for (int j = 0; j < n; j++)
            {
                matr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Первоначальный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write("{0,5}", matr[i, j]);
            Console.WriteLine();
        }
        for (int j = 0; j < n; j++) 
        {

            max = matr[0, j];

            for (int i = 1; i < m; i++)
            {
                if (matr[i, j] > max)
                {
                    max = matr[i, j];
                }
            }
            if (min > max || j == 0)
                min = max;
        }
        Console.WriteLine("Минимальный элемент: " + min);
        Console.ReadLine();
    }
}
