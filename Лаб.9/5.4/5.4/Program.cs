using System;
using System.Diagnostics.CodeAnalysis;

class Worker
{
    private int year;
    private double salary = 1;
    private string name = "No_name", post = "No_post", educ = "No_educ";
    public int Year { get { return year; } set { if (value > 1900 && value < 2006) { year = value; } else { Console.WriteLine("Введено невозможное значение."); } } }
    public double Salary { get { return salary; } set { if (value > 0) { salary = value; } else { Console.WriteLine("Значение должно быть положительным. По умолчанию присвоино 1."); } } }
    public string Name { get { return name; } set { if (value != "") { name = value; } else { Console.WriteLine("Ошибка: пустая строка. По умолчанию присвоино No_name"); } } }
    public string Post { get { return post; } set { if (value != "") { post = value; } else { Console.WriteLine("Ошибка: пустая строка. По умолчанию присвоино No_post"); } } }
    public string Educ { get { return educ; } set { if (value != "") { educ = value; } else { Console.WriteLine("Ошибка: пустая строка. По умолчанию присвоино No_educ"); } } }
    public Worker(int Year, double Salary, string Name, string Post, string Educ)
    {
        this.Year = Year;
        this.Salary = Salary;
        this.Name = Name;
        this.Post = Post;
        this.Educ = Educ;
    }
    public string Info()
    {
        return $"|{name, -30}|{year, 15}|{post, -20}|{salary, 15:0.00}|{educ, -20}|\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Worker[] workers = Create();
        if (Quantity(workers) == 0)
        {
            Console.WriteLine("Нет удовлетворяющих сотрудников!");
        }
        else
        {
            Console.WriteLine("Кол-во сотрудников старше 60 лет: " + Quantity(workers));
            Print();
            Console.Write(Сount(workers));
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------|");
        }
    }
    static void Print()
    {
        Console.WriteLine("|--------------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|          ФИО сотрудника      | год рождения  |      должность     |   зарплата    |    образование     |");
        Console.WriteLine("|--------------------------------------------------------------------------------------------------------|");
    }
    static Worker[] Create()
    {
        int N;
        Console.WriteLine("Введите кол-во сотрудников: ");
        N = Convert.ToInt16(Console.ReadLine());
        Worker[] workers = new Worker[N];
        for (int i = 0; i < workers.Length; i++)
        {
            int year;
            double selery;
            string name, post, educ;
            Console.WriteLine("Введите ФИО {0} сотрудника: ", i + 1);
            name = Console.ReadLine();
            Console.WriteLine("Год рождения: ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Должность: ");
            post = (Console.ReadLine());
            Console.WriteLine("Зарплата: ");
            selery = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Образование: ");
            educ = Console.ReadLine();
            workers[i] = new Worker(year, selery, name, post, educ);
        }
        return workers;
    }
    static int Quantity(Worker[] workers)
    {
        int k = 0;
        for (int i = 0; i < workers.Length; i++)
        {
            if (workers[i].Year < 1963)
            {
                k++;
            }
        }
        return k;
    }
    static string Сount(Worker[] workers)
    {
        string result = "";
        for (int i = 0; i < workers.Length; i++)
        {
            if (workers[i].Year < 1962)
            {
                result += workers[i].Info();
            }
        }
        return result;
    }
}