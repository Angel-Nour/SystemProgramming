using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text;
        int i, a = 0, o = 0;
        Console.WriteLine("Введите строку");
        text = Console.ReadLine().Trim();
        text = text.ToLower();
        for (i = 0; i < text.Length; i++)
        {
            if (text[i] == 'o')
                o++;
            if (text[i] == 'a')
                a++;
        }
        if (a == o)
            Console.WriteLine("Букв A и O одинаковое кол-во");
        else if (a < o)
            Console.WriteLine("Букв 'O' больше");
        else
            Console.WriteLine("Букв 'A' больше");
       
        Console.ReadLine();
    }
}