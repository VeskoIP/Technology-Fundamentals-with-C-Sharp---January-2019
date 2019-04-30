using System;
using System.Linq;

class EqualSums
{
    static void Main()
    {
        int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int sumLeft = 0;
        int sumRight = 0;
        bool ifPrint = false;

        for (int i = 0; i < myArr.Length; i++)
        {

            if (i != 0)
            {
                for (int k = 0; k < i; k++)
                {
                    sumLeft += myArr[k];
                }
            }

            if (i != myArr.Length - 1)
            {
                for (int m = i + 1; m < myArr.Length; m++)
                {
                    sumRight += myArr[m];
                }
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine(i);
                ifPrint = true;
                break;
            }
            else
            {
                sumLeft = sumRight = 0;
            }
        }

        if (ifPrint == false)
        {
            Console.WriteLine("no");
        }
    }
}