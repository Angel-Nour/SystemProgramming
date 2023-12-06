using System;
class Program
{
    static void Main()
    {
        int n, i, a, b;
        Random rand = new Random();
        Console.WriteLine("Введите количество элементов массива");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите диапазон [a ; b]: \na = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Исходный массив:");
        for (i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(a, b + 1);
            Console.Write(" " + arr[i]);
        }
        int max = arr[0];
        for (i = 0; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
                max = arr[i];
        }
        Console.WriteLine("\nПреобразованный массив:");
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] == max)
            {
                arr[i] = arr[arr.Length - 1];
                break;
            }
        }
        for (i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);
        }
        Console.ReadLine();
    }
}