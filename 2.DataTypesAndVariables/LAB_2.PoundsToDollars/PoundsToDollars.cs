using System;

class PoundsToDollars
{
    static void Main()
    {
        decimal input = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"{input * 1.31m:F3}");
    }
}