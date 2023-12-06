using System;
class Program
{
    static void Main()
    {
        int a, q;
        Console.WriteLine("Введите a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите q: ");
        q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Элементы массива: ");
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = a;
            Console.Write("{0} ", arr[i]);
            a *= q;
        }
        Console.ReadLine();
    }
}

