using System;

class SumOfChars
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        char[] myArray = new char[n];
        int sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = char.Parse(Console.ReadLine());
            sum += (int)myArray[i];
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}