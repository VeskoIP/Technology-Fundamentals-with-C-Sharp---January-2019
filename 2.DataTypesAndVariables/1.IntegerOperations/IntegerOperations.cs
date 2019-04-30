using System;

class IntegerOperations
{
    static void Main()
    {
        int[] myArray = new int[4];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(((myArray[0] + myArray[1]) / myArray[2]) * myArray[3]);
    }
}