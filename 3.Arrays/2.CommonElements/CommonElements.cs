using System;
using System.Linq;

class CommonElements
{
    static void Main()
    {
        string[] firstArr = Console.ReadLine().Split().ToArray();
        string[] secondArr = Console.ReadLine().Split().ToArray();

        for (int i = 0; i < secondArr.Length; i++)
        {
            for (int k = 0; k < firstArr.Length; k++)
            {
                if (secondArr[i] == firstArr[k])
                {
                    Console.Write($"{secondArr[i]} ");
                }
            }
        }
    }
}