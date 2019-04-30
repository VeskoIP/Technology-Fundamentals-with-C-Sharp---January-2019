using System;
using System.Text;

class ReversedChars
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= 3; i++)
        {
            sb.Append(Console.ReadLine());
        }

        for (int i = 2; i >= 0; i--)
        {
            Console.Write($"{sb[i]} ");
        }
    }
}