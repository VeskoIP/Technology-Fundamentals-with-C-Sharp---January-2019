using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int counter = 0;
        int countMax, num;
        countMax = 0;

        int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        num = myArr[0];

        for (int i = myArr.Length - 1; i > 0; i--)
        {
            if (myArr[i] == myArr[i - 1])
            {
                counter++;
                if (counter >= countMax)
                {
                    countMax = counter;
                    num = myArr[i];
                }
            }

            else
            {
                counter = 0;
            }
        }

        for (int i = 0; i <= countMax; i++)
        {
            Console.Write($"{num} ");
        }
    }
}