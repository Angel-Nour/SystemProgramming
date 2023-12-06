using System;
class Program
{
    static void Main()
    {
        int m, n, S = 0, k = 0;
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


        Console.WriteLine("Сумма четных элементов строки:");
        for (int i = 0; i < m; i++) // просмотр по строкам
        {
            S = 0;
            for (int j = 0; j < n; j++)
                if (matr[i, j] % 2 == 0)
                    S += matr[i, j];
            Console.WriteLine("{0}-й строки: {1}", i + 1, S);
        }


        Console.WriteLine("Сумма четных элементов столбца:");
        for (int j = 0; j < n; j++) // просмотр по столбцам
        {
            S = 0;
            for (int i = 0; i < m; i++)
                if (matr[i, j] % 2 == 0)
                    S += matr[i, j];
            Console.WriteLine("{0}-й столбца: {1}", j + 1, S);
        }


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matr[i, j] % 3 == 0 || matr[i, j] % 2 == 0)
                {
                    k++;
                }
            }
        }



        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matr[i, j] > 0)
                    matr[i, j] *= 2;
            }
        }


        Console.WriteLine("Кол-во элементов, кратных 2 или 3: " + k);
        Console.WriteLine("Массив после преобразования:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write("{0,5}", matr[i, j]);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}