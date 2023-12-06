using System;
class Program
{
    static void Main()
    {
        int a, b, k, del = 0;
        bool flag=true;
        Console.WriteLine("Введите промежутки чисел [a ; b]: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество делителей: ");
        k = Convert.ToInt32(Console.ReadLine());
        for (int v = a; v <= b; v++)
        {
            del = 0;
            for (int i = 1; i <= v; i++)
                if (v % i == 0)
                {
                    del++;
                    
                }
            if (k == del)
            {
                Console.WriteLine("Подходящее число: " + v);
                flag = false;
            }
            
        }
        if (flag)
        {
            Console.WriteLine("Нет подходящих значений");
        }
       Console.ReadLine();
    }
}
            

