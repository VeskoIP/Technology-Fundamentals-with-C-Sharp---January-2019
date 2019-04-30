using System;
using System.Linq;

class MagicSum
{
    static void Main()
    {
        int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < myArr.Length - 1; i++)
        {
            for (int k = i + 1; k < myArr.Length; k++)
            {
                if (myArr[i] + myArr[k] == num)
                {
                    Console.WriteLine($"{myArr[i]} {myArr[k]}");
                }
            }
        }
    }
}