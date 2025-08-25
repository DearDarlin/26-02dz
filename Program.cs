using System;

public static class Fibonacci
{
    public static bool IsFibonacci(int n)
    {
        if (n < 0) return false;
        int a = 0, b = 1;
        while (a < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == n;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        if (Fibonacci.IsFibonacci(number))
        {
            Console.WriteLine($"{number} is a Fibonacci number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Fibonacci number.");
        }
    }
}