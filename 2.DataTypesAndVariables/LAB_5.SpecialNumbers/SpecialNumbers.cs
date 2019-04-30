using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string num = null;
        int numToInt = 0;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            num = i.ToString();
            for (int k = 0; k < num.Length; k++)
            {
                numToInt = (int)Char.GetNumericValue(num[k]);
                sum += numToInt;
            }

            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
            sum = 0;
        }
    }
}