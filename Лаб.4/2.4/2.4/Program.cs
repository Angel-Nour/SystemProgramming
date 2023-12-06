using System;
class Program
{
    static void Main()
    {
        int n, a, b, c, k=0, s=123;
        Console.WriteLine("Введите трехзначное натуральное число n");
        n = Convert.ToInt32(Console.ReadLine());
        if (n < s)
            Console.WriteLine("До введенного числа нет трехзначного числа с возрастающей последовательностью цифр");
        else
        {
            Console.WriteLine("Числа с возрастающей последовательностью цифр: ");
            while (s <= n)
            {
                a = s / 100;
                b = s % 100 / 10;
                c = s % 10;
                if (a < b && b < c)
                {
                    Console.WriteLine(s);
                    k++;
                }
                s++;
            }
            Console.WriteLine("Количество подходящих цифр: " + k);
        }
        Console.ReadLine();
    }
}