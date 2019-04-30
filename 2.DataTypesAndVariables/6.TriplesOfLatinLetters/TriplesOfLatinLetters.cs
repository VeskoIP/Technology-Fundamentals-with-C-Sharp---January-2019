using System;

class TriplesOfLatinLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 97; i < 97 + n; i++)
        {
            for (int k = 97; k < 97 + n; k++)
            {
                for (int m = 97; m < 97 + n; m++)
                {
                    Console.WriteLine($"{ (char)i}{ (char)k}{ (char)m}");
                }
            }
        }
    }
}