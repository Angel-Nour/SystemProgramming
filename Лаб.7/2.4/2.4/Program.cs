using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text;
        Console.WriteLine("Введите строку");
        text = Console.ReadLine().Trim();
        text = Regex.Replace(text, "[0-9]", "", RegexOptions.IgnoreCase);
        Console.WriteLine(text);
        Console.ReadLine();
    }
}
