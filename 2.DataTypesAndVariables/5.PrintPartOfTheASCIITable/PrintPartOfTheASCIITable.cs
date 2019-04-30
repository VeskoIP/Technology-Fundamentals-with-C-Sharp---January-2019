using System;

class PrintPartOfTheASCIITable
{
    static void Main()
    {
        int begin = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for (int i = begin; i <= end; i++)
        {
            Console.Write($"{(char)i} ");
        }
    }
}