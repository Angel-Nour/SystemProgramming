using System;
class Program
{
    static void Main()
    {
        int j, i, n, imin, t;
        Console.WriteLine("Введите количество элементов");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        
        Console.WriteLine("Введите элементы массива");
        for (i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < arr.Length - 1; i++)
        {
            imin = i;
            for (j = i; j < arr.Length; j++)
            {
                if (arr[j] < arr[imin])
                    imin = j;
            }
            t = arr[i];
            arr[i] = arr[imin];
            arr[imin] = t;
        }
       
        

        Console.WriteLine("Измененный массив: ");
        for (i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
