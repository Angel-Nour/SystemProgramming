using System;
class Program
{
    static void Main()
    {
        int a, b, p1, p2, p3, o1, o2, o3;
        Console.Write("Введите диапазон [a ; b]: \na = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        int[] A = Create(a, b);
        int[] B = Create(a, b);
        int[] C = Create(a, b);
        p1 = kol_p(A);
        o1 = kol_o(A);
        p2 = kol_p(B);
        o2 = kol_o(B);
        p3 = kol_p(C);
        o3 = kol_o(C);
        if (p1 == o1)
        {
            Console.WriteLine("\nМассив с одинак. кол-вом отр. и пол. эл.");
            print(A);
        }
        if (p2 == o2)
        {
            Console.WriteLine("\nМассив с одинак. кол-вом отр. и пол. эл.");
            print(B);
        }
        if (p3 == o3)
        {
            Console.WriteLine("\nМассив с одинак. кол-вом отр. и пол. эл.");
            print(C);
        }
        if ((p1 != o1) && (p2 != o2) && (p3 != o3))
        {
            Console.WriteLine("\nНет интересующего массива");
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
    static int kol_p (int[] arr)
    {
        int p = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                p++;
            }
           
        }
        return p;
    }
    static int kol_o (int[] arr)
    {
        int o = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                o++;
            }
        }
        return o;
    }
    static void print (int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);
        }
    }
}