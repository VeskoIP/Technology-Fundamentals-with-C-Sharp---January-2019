using System;
using System.Linq;

class ArrayRotation
{
    static void Main()
    {
        string[] myArr = Console.ReadLine().Split().ToArray();
        int num = int.Parse(Console.ReadLine());
        int numOfRotation = num - (num / myArr.Length) * myArr.Length;

        for (int i = numOfRotation; i < myArr.Length; i++)
        {
            Console.Write($"{myArr[i]} ");
        }

        for (int i = 0; i < numOfRotation; i++)
        {
            Console.Write($"{myArr[i]} ");
        }
    }
}