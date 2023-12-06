//using System;
//class Program
//{
//  static void Main()
//{
//  int n, k = 0;
//bool f = true;
//Console.WriteLine("Введите трехзначное натуральное число n >= 123");
//n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Числа с возрастающей последовательностью цифр: ");
//for (int s = 123; s <= n; s++)
//{
//  int i = s, previus = i % 10;
//i /= 10;
//while (i > 0)
//{
//               int current = i % 10;
//             if (current >= previus)
//           {
//             f = false;
//       }
//     i /= 10;
//   previus = current;

//           }
//         if (f)
//       {
//         k++;
//       Console.WriteLine(s);
// }
//f = true;
//}

//  Console.WriteLine("Кол-во: " + k);
//Console.ReadLine();
//}
//}
using System;
class Program
{
    static void Main()
    {
        int n, k = 0, a, b, c, n2;
        Console.WriteLine("Введите трехзначное натуральное число n >= 123");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Числа с возрастающей последовательностью цифр: ");
        for (a = 1; a <= 9; a++)
        {
            for (b = 1; b <= 9; b++)
            {
                for (c = 1; c <= 9; c++)
                {
                    n2 = (100 * a + 10 * b + c);
                    if ((n2 <= n) && a < b && b < c)
                    {
                        k++;
                        Console.WriteLine(n2);
                    }
                }

               
            }
        }
        Console.WriteLine("Кол-во: " + k);
        Console.ReadLine();
    }
}
