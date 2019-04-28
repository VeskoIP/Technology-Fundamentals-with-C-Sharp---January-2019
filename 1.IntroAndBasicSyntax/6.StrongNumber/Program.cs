using System;

class StrongNumber
{
    static void Main()
    {
        string num = Console.ReadLine();
        int numToInt = Int32.Parse(num);
        int sum = 0;
        int multiplication = 1;

        for (int i = 0; i < num.Length; i++)
        {
            for (int k = 1; k <= (int)Char.GetNumericValue(num[i]); k++)
            {
                multiplication = multiplication * k;
            }

            sum += multiplication;
            multiplication = 1;
        }

        if (sum == numToInt)
        {
            Console.WriteLine("yes");
        }

        else
        {
            Console.WriteLine("no");
        }
    }
}