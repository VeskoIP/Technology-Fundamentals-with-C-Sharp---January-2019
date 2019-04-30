using System;

class SumDigits
{
    static void Main()
    {
        string num = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < num.Length; i++)
        {
            sum += (int)Char.GetNumericValue(num[i]);
        }

        Console.WriteLine(sum);
    }
}