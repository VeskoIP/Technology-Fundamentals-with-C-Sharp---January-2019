using System;

class BeerKegs
{
    static void Main()
    {
        int numOfKegs = int.Parse(Console.ReadLine());
        string model = null;
        string maxModel = null;

        double radius = 0;
        int height = 0;
        double volume = 0;
        double maxVolume = 0;

        for (int i = 0; i < numOfKegs; i++)
        {
            model = Console.ReadLine();
            radius = double.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());
            volume = Math.PI * Math.Pow(radius, 2) * height;

            if (volume > maxVolume)
            {
                maxVolume = volume;
                maxModel = model;
            }
        }
        Console.WriteLine(maxModel);
    }
}