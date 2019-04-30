﻿using System;

class RefactoringPrimeChecker
{
    static void Main()
    {
        int upRange = int.Parse(Console.ReadLine());

        for (int i = 2; i <= upRange; i++)
        {
            bool isPrime = true;
            for (int k = 2; k < i; k++)
            {
                if (i % k == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLowerInvariant());
        }
    }
}