using System;
class Program
{
    static void Main()
    {
        double a, b, c;
        Console.WriteLine("Введите три стороны треугольника: ");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                Console.WriteLine("Треугольник: Прямоугольный");
        else if ((a * a + b * b < c * c) || (a * a + c * c < b * b) || (c * c + b * b < a * a))
            Console.WriteLine("Треугольник: Тупоугольный");
        else if ((a * a + b * b > c * c) || (a * a + c * c > b * b) || (c * c + b * b > a * a))
            Console.WriteLine("Треугольник: Остроугольный");
        if (a == b && b == c)
            Console.WriteLine("Треугольник: Равносторонний");
        else if (a == b && a != c || b == c && b != a || c == a && c != b)
            Console.WriteLine("Треугольник: Равнобедренный");
        else
            Console.WriteLine("Треугольник: Разносторонний");
        Console.ReadLine();

    }
}




