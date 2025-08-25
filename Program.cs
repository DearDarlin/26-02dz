using System;

public static class StringExtensions {
    public static int LastWordLenght(this string str) {
        if (string.IsNullOrWhiteSpace(str)) return 0;
        var words = str.Trim().Split(' ');
        return words[^1].Length;
    }
        
}


class Program
{
    static void Main()
    {
        string example = "Hello Darina";
        int length = example.LastWordLenght();
        Console.WriteLine($"The length of the last word is: {length}");
    }
}