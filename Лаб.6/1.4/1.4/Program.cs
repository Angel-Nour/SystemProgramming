using System;
class Program
{
    static void Main()
    {
        const int n = 7;
        int[,] matr = new int[n, n];
        Console.WriteLine("Заполненный массив:");
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (i == j || i +j == n-1 || i == 3 || j == 3)
                    matr[i, j] = 1;
            }
        }
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                Console.Write("{0,3}", matr[i, j]);
            Console.WriteLine();
        }
    }
}