using System;

public static class StringExtensions {
    public static bool ContainsCaseSensitive(this string source, string toCheck)
    {
        return source.IndexOf(toCheck, StringComparison.Ordinal) >= 0;
    }
}


class Program
{
    static void Main()
    {
        string source = "Hello World";
        string toCheck1 = "world";
        string toCheck2 = "World";
        bool result1 = source.ContainsCaseSensitive(toCheck1);
        bool result2 = source.ContainsCaseSensitive(toCheck2);
        Console.WriteLine($"{toCheck1} - {result1}");
        Console.WriteLine($"{toCheck2} - {result2}");
    }
}
