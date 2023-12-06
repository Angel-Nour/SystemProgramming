using System;
class Program
{
    static void Main()
    {
        int i, j;
        for (j = 1; j <= 5; j+=2)
        {
            for (i = 1; i <= 5; i++)
                Console.Write("{0,3}", j);
            Console.WriteLine();
        }
     
        Console.ReadLine();
    }
}
