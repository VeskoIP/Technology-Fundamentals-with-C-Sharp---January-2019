using System;
using System.Linq;

class PascalTriangle
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        int[] firstArr = new int[rows];
        firstArr[0] = 1;
        int[] lastArr = new int[rows];

        if (rows == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(1);
            for (int i = 2; i <= rows; i++)
            {
                lastArr[0] = 1;
                lastArr[i - 1] = 1;

                for (int k = 1; k < (int)Math.Ceiling(i / 2.0); k++)
                {
                    lastArr[k] = firstArr[k - 1] + firstArr[k];
                    if (i % 2 == 0 && k == (int)Math.Ceiling(i / 2.0) - 1)
                    {
                        lastArr[k + 1] = lastArr[k];
                    }
                }

                Array.Clear(firstArr, 0, firstArr.Length);

                for (int k = 0; k < (int)Math.Ceiling(i / 2.0); k++)
                {
                    Console.Write($"{lastArr[k]} ");
                }

                if (i % 2 != 0)
                {
                    for (int k = (int)Math.Ceiling(i / 2.0) - 2; k >= 0; k--)
                    {
                        Console.Write($"{lastArr[k]} ");
                    }
                }

                else
                {
                    for (int k = (int)Math.Ceiling(i / 2.0) - 1; k >= 0; k--)
                    {
                        Console.Write($"{lastArr[k]} ");
                    }
                }

                Console.WriteLine();
                Array.Copy(lastArr, firstArr, rows);
            }
        }
    }
}