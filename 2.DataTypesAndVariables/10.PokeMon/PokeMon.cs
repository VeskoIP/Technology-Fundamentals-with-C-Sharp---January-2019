using System;

class PokeMon
{
    static void Main()
    {
        int pokePower = int.Parse(Console.ReadLine());
        int pokePowerM = pokePower;
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());
        int count = 0;

        while (pokePower >= distance)
        {
            pokePower = pokePower - distance;
            count++;
            if (pokePower == pokePowerM * 0.5 && exhaustionFactor != 0)
            {
                pokePower = pokePower / exhaustionFactor;
            }
        }

        Console.WriteLine(pokePower);
        Console.WriteLine(count);
    }
}