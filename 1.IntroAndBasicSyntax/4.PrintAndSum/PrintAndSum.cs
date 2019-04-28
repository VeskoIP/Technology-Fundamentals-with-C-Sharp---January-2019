using System;

class PrintAndSum
{
    static void Main()
    {
        int numStart = int.Parse(Console.ReadLine());
        int numEnd = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = numStart; i <= numEnd; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }

        Console.WriteLine();
        Console.WriteLine("Sum: {0}", sum);
    }
}