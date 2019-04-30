using System;

class WaterOverflow
{
    static void Main()
    {
        int waterTank = 0;
        byte n = byte.Parse(Console.ReadLine());
        int liters = 0;

        for (int i = 1; i <= n; i++)
        {
            liters = int.Parse(Console.ReadLine());
            if (liters <= 255 - waterTank)
            {
                waterTank += liters;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }

        Console.WriteLine(waterTank);
    }
}