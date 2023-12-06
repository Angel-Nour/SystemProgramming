using System;
class Program
{
    static void Main()
    {
        int a, b;
        Console.Write("Введите диапазон [a ; b]: \na = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        int[] A = Create(a, b);
        int[] B = Create(a, b);
        if (Sr(A) > Sr(B))
        {
            Console.WriteLine("\nНаибольший: ");
            print(A);
            Console.WriteLine("\nНаименьший: ");
            print(B);
        }
        else if (Sr(A) < Sr(B))
        {
            Console.WriteLine("\nНаибольший: ");
            print(B);
            Console.WriteLine("\nНаименьший: ");
            print(A);
        }
        else
        {
            Console.WriteLine("\nСр. ар. знач. чет. чисел у массивов равны");
        }

    }
    static int[] Create(int a, int b)
    {
        Console.WriteLine("\nВведите количество элементов массива");
        int d = Convert.ToInt32(Console.ReadLine());
        Random rand = new Random();
        int[] arr = new int[d];
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(a, b + 1);
            Console.Write(" " + arr[i]);
        }
        return arr;
    }
    static double Sr(int[] arr)
    {
        int s = 0, k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                s += arr[i];
                k++;
            }
        }
        if (k == 0)
        {
            return 0;
        }
        return s / k;
    }
    static void print(int[] arr)
        {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);
        }
    }
}