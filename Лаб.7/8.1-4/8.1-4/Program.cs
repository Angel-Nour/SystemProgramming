using System;
class Program
{
    static void Main()
    {
        string text;
        char[] arr1;
        int k, i;
        k = 0;
        char ch;
        Console.Write("Введите строку: ");
        text = Console.ReadLine();
        k = text.Length;
        arr1 = text.ToCharArray(0, k);

        Console.Write("Измененная строка: ");
        for (i = 0; i < k; i++)
        {
            ch = arr1[i];
            if (Char.IsLower(ch))
                Console.Write(Char.ToUpper(ch));
            else
                Console.Write(Char.ToLower(ch));
        }
        Console.ReadLine();
    }

}