using System;
class Program
{
    static void Main()
    {
        int n, i;
        Console.WriteLine("Введите количество элементов");
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Измененный масив: ");
        int max = array[0];
        for (i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
                max = array[i];
        }
        for (i=0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] = -max;
            }
            Console.Write("  " + array[i]);
        }
        
        Console.ReadLine();
    }
}