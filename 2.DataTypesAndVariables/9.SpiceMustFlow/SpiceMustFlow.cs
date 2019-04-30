using System;

class SpiceMustFlow
{
    static void Main()
    {
        int startingYield = int.Parse(Console.ReadLine());
        int totalAmount = 0;
        int count = 0;

        while (startingYield >= 100)
        {
            totalAmount = totalAmount + (startingYield - 26);
            startingYield = startingYield - 10;
            count++;
        }

        Console.WriteLine(count);

        if (totalAmount - 26 < 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(totalAmount - 26);
        }
    }
}