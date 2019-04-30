using System;
using System.Linq;

class Train
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] people = new int[n];

        for (int i = 0; i < n; i++)
        {
            people[i] = int.Parse(Console.ReadLine());
        }

        foreach (int item in people)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
        Console.WriteLine(people.Sum());
    }
}