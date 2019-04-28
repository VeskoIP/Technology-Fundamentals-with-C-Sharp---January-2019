using System;

class TriangleOfNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}