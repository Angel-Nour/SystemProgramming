using System;
class Program
{
    static void Main()
    {
        int m, n, a, b, max;
        Random rand = new Random();
        Console.WriteLine("Введите количество строк");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите диапазон [a ; b]: \na = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[m, n];
        Console.WriteLine("Первоначальный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = rand.Next(a, b + 1);
                Console.Write("{0,5} ", arr[i, j]);
            }
            Console.WriteLine();
        }
        for (int i = 0; i < m; i++)
        {
            int t = 0, k = 0;
            max = arr[i, 0];
            for (int j = 0; j < n; j++)
            {
                
                if (arr[i, j] >= max)
                {
                    max = arr[i, j];
                    t = j;
                    k++;
                }
               
            }
            arr[i, t] = t;
            for (int c = 0; c < k; c++)
            {
                if (arr[i, c] == max)
                    arr[i, c] = c;
            }
            
        }
        Console.WriteLine("Массив после преобразования:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write("{0,5}", arr[i, j]);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}