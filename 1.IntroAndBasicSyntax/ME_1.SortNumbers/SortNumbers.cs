using System;

class SortNumbers
{
    static void Main(string[] args)
    {
        int[] myArray = new int[3];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArray);
        Array.Reverse(myArray);

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}