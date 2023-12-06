
int sum = 0, v, s;
Console.WriteLine("ппппп");
v = Convert.ToInt32(Console.ReadLine());    
while (v > 0)
{
    s = v % 10;
    sum += s;
    v /= 10;
}
Console.WriteLine("Максимальная сумма цифр числа : " + sum);