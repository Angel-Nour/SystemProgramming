using System;
class Program
{
    static void Main()
    {
        string text, a = "а";
        Console.WriteLine("Введите строку");
        text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '!', '.', ':', ';', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Слова начинающиеся или оканчивающиеся на букву А:");
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][0] == Convert.ToChar(a.ToLower()) || words[i][0] == Convert.ToChar(a.ToUpper()) || words[i][words[i].Length - 1] == Convert.ToChar(a.ToLower()) || words[i][words[i].Length - 1] == Convert.ToChar(a.ToUpper()))
                Console.WriteLine(words[i]);
        }
        Console.ReadLine();
    }
}