using System;
class Program
{
    static void Main()
    {
        int m, n;
        Console.WriteLine("Введите количество строк");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        n = Convert.ToInt32(Console.ReadLine());
        int[,] matr = new int[m, n];
        Console.WriteLine("Заполненный массив:");
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (i == 0 || j == 0)
                    matr[i, j] = 1;
            }
        }
        for (int i = 1; i < matr.GetLength(0); i++)
        {
            for (int j = 1; j < matr.GetLength(1); j++)
            {
                matr[i, j] = matr[i - 1, j] + matr[i, j - 1];
            }
        }
               
                for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                Console.Write("{0,6}", matr[i, j]);
            Console.WriteLine();
        }
    }
}