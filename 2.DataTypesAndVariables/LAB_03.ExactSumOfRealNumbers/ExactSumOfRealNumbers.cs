using System;

class ExactSumOfRealNumbers
{
    static void Main()
    {
        int nums = int.Parse(Console.ReadLine());
        decimal[] myArr = new decimal[nums];
        decimal sum = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            sum += decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}