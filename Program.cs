using System;
using System.Collections.Generic;

public static class ArrayExtensions
{
    public static int[] Filter(this int[] array, Predicate<int> predicate)
    {
        if (array == null) return Array.Empty<int>();

        List<int> result = new List<int>();
        foreach (var item in array)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
}

class ProgramTask6
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] even = numbers.Filter(n => n % 2 == 0);
        int[] odd = numbers.Filter(n => n % 2 != 0);

        Console.WriteLine("Even: " + string.Join(", ", even));
        Console.WriteLine("Odd: " + string.Join(", ", odd));
    }
}
