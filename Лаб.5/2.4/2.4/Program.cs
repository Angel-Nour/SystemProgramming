using System;
class Program
{
    static void Main()
    {
        int n, i, k2 = 0, s1 = 0, k=0, t=0, j=0;
        Console.WriteLine("Введите количество элементов");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < n; i++)
        {
            if (arr[i] < 0 && arr[i] % 5 == 0)
            {
                s1 += arr[i];
            }
            
            if (arr[i] > 9 && arr[i] < 100 || arr[i] > -100 && arr[i] < -9)
            {
                k++;
            }
            if (arr[i] > 0 && arr[i] % 7 == 0)
            {
                k2++;
            }
            if (t == 0 && arr[i] > 0 && (arr[i] % 2 == 0))
            {
                j = i;
                t++;
            }
        }
        if (s1 == 0)
            Console.WriteLine("Нет отр. эл. кр. 5 ");
        else
            Console.WriteLine("Сумма отр. эл. кр. 5: " + s1);
        if (k == 0)
            Console.WriteLine("Нет двузначных чисел: ");
        else
            Console.WriteLine("Кол-во двузначных чисел: " + k);
        if (k2 > 0)
            Console.WriteLine("Есть пол. элементы кр. 7 ");
        else
            Console.WriteLine("Нет пол. этементов кр. 7");
        if (t == 0)
            Console.WriteLine("Нет пол. чет. эл.");
        else
            Console.WriteLine("Индекс первого чет. пол. эл.: " + j);
    }
}
            