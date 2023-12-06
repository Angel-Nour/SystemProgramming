using System;
class Program
{
    static void Main()
    {
        double funt, kg;
        Console.WriteLine("|---------------------|");
        Console.WriteLine("|  Фунты | Килограммы |");
        Console.WriteLine("|---------------------|");
        for (funt = 1; funt <= 20; funt++)
            Console.WriteLine("|{0,7} |{1,8:0.0000}    | ", funt, kg = funt * 0.45359237) ;
        Console.WriteLine("|---------------------|");
        Console.ReadLine();
    }
}
;
