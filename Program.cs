using System;

public static class StringExtensions
{
    public static string WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return "0 words";
        }
        var wordCount = str.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        return $"{wordCount} words";
    }

}

class Program
{
    static void Main()
    {
        string text = "Hello, my dear cat.";
        Console.WriteLine(text.WordCount()); 
    }
}