using System;

class ConvertMetersToKilometers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", a / 1000.0);
    }
}