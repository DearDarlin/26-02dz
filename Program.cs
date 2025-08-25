using System;
using System.Collections.Generic;

public static class StringExtensions {
    public static bool BracketsValid(this string value) {
        var stack = new Stack<char>();
        var brackets = new Dictionary<char, char> {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        foreach (var ch in value)
        {
            if (brackets.ContainsKey(ch))
            {
                stack.Push(ch);
            }
            else if (brackets.ContainsValue(ch))
            {
                if (stack.Count == 0 || brackets[stack.Pop()] != ch)
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        string test1 = "{}[]";
        string test2 = "[[{]}]";
        Console.WriteLine($"{test1} is valid: {test1.BracketsValid()}");
        Console.WriteLine($"{test2} is valid: {test2.BracketsValid()}");
    }
}