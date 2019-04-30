using System;
using System.Linq;

class TopIntegers
{
    static void Main()
    {
        int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool check = true;

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            check = true;
            for (int k = i + 1; k < myArr.Length; k++)
            {
                if (myArr[i] <= myArr[k])
                {
                    check = false;
                    break;
                }
            }

            if (check == true)
            {
                Console.Write($"{myArr[i]} ");
            }
        }

        Console.Write($"{myArr[myArr.Length - 1]} ");
    }
}