using System;
class Straight
{
    public double x1, y1, x2, y2;

    public Straight(double X1, double Y1, double X2, double Y2)
    {
        x1 = X1;
        y1 = Y1;
        x2 = X2;
        y2 = Y2;
    }

    public void Find()
    {
        if (x2 == x1)
            Console.WriteLine("Уравнение прямой x = {0}", x1);
        else if (y2 == y1)
            Console.WriteLine("Уравнение прямой y = {0}", y1);
        else
        {
            if (y1 - ((y2 - y1) / (x2 - x1)) * x1 < 0)
                Console.WriteLine("Уравнение прямой y = {0}x {1}", (y2 - y1) / (x2 - x1), y1 - ((y2 - y1) / (x2 - x1)) * x1);
            else if (y1 - ((y2 - y1) / (x2 - x1)) * x1 == 0)
                Console.WriteLine("Уравнение прямой y = {0}x", (y2 - y1) / (x2 - x1));
            else
                Console.WriteLine("Уравнение прямой y = {0}x + {1}", (y2 - y1) / (x2 - x1), y1 - ((y2 - y1) / (x2 - x1)) * x1);
        }
    }
    public void Info()
    {
        Console.WriteLine("Прямая проходящая через точки: ({0};{1}) и ({2};{3}) ", x1, y1, x2, y2);
    }
}
class Program
{
    static void Main(string[] args)
    {

        Straight[] arr = Create();
        Print(arr);
        Console.ReadLine();
    }
    static void Print(Straight[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].Info();
            arr[i].Find();
        }
    }
    static Straight[] Create()
    {
        Console.WriteLine("\nВведите количество прямых");
        int N = Convert.ToInt32(Console.ReadLine());
        Straight[] arr = new Straight[N];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Введите координаты {0} прямой (x1 y1 x2 y2) ", i+1);
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            arr[i] = new Straight(x1, y1, x2, y2);
        }
        return arr;
    }

}