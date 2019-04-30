using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int numOfSnowballs = int.Parse(Console.ReadLine());

        int snowballSnow = 0;
        int snowballSnowMax = 0;

        int snowballTime = 1;
        int snowballTimeMax = 1;

        int snowballQuality = 0;
        int snowballQualityMax = 0;

        BigInteger snowballValue = 0;
        BigInteger snowballValueMax = 0;

        for (int i = 1; i <= numOfSnowballs; i++)
        {
            snowballSnow = int.Parse(Console.ReadLine());
            snowballTime = int.Parse(Console.ReadLine());
            snowballQuality = int.Parse(Console.ReadLine());
            snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

            if (snowballValue >= snowballValueMax)
            {
                snowballSnowMax = snowballSnow;
                snowballTimeMax = snowballTime;
                snowballQualityMax = snowballQuality;
                snowballValueMax = snowballValue;
            }
        }

        Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
    }
}