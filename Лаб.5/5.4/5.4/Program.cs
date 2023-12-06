using System;
class Program
{
    static void Main()
    {
        int n, i;
        double sr = 0;
        Console.WriteLine("Введите количество элементов");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int[] arr2 = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < arr.Length; i++)
        {
            sr += arr[i];
        }
        sr /= n;
        Console.WriteLine("Измененный массив: ");
        int k = 0;
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] < sr)
            {
                arr2[k] = arr[i];
                k++;
            }
        }
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= sr)
            {
                arr2[k] = arr[i];
                k++;
            }
        }
        Console.WriteLine(" " + string.Join(",", arr2));
        Console.ReadLine();
    }
}