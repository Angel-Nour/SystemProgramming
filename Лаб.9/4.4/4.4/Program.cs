using System;
using System.Diagnostics.CodeAnalysis;

class Product
{
    private int number = 1;
    private double weight = 1;
    private string name = "No_name";
    public int Number { get { return number; } set { if (value > 0) { number = value; } else { Console.WriteLine("Номер должен быть положительным. Присвоено значение по умолчанию 1."); } } }
    public double Weight { get { return weight; } set { if (value > 0) { weight = value; } else { Console.WriteLine("Вес должен быть положительным. Присвоено значение по умолчанию 1."); } } }
    public string Name { get { return name; } set { if (value != "") { name = value; } else { Console.WriteLine("Ошибка: пустая строка. Присвоено значение по умолчанию No_name"); } } }

    public Product(int Number, double Weight, string Name)
    {
        this.Number = Number;
        this.Weight = Weight;
        this.Name = Name;
    }
    public string Info()
    {
        return $"Номер продукта: {number} / Название: {name} / Вес : {weight}.\n";
    }

}
class Program
{
    static void Main(string[] args)
    {
        Product[] products = Create();
        Console.WriteLine("Информация о продуктах:\n" + Print(products)); 
        double sr = Average(products);
        Console.WriteLine("Информация о продуктах, чей вес больше ср.ар. веса всех продуктов:\n" + Сompare(products, sr)); 

    }
    static Product[] Create ()
    {
        int N;
        Console.WriteLine("Введите кол-во продуктов: ");
        N = Convert.ToInt16(Console.ReadLine());
        Product[] products = new Product[N];
        for(int i = 0; i < products.Length; i++)
        {
            int number;
            double weight;
            string name;
            Console.WriteLine("Введите номер {0} продукта: ", i + 1);
            number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Название: ");
            name = Console.ReadLine();
            Console.WriteLine("Вес: ");
            weight = Convert.ToDouble(Console.ReadLine());
            products[i] = new Product (number, weight, name);
        }
        return products;
    }
    static double Average(Product[] products)
    {
        int k = 0;
        double sum = 0;
        for (int i = 0; i < products.Length; i++)
        {
            sum += products[i].Weight;
            k++;
        }
        return sum / k;
    }
    static string Сompare(Product[] products, double sr)
    {
        string result = "";
        for (int i = 0;i < products.Length;i++)
        {
            if (products[i].Weight > sr)
            {
                 result += products[i].Info();
            }
        }
        return result;
    }
    static string Print(Product[] products)
    {
        string tekst = "";
        for (int i = 0; i < products.Length; i++)
        {
           tekst += products[i].Info();
        }
        return tekst;
    }
}
   