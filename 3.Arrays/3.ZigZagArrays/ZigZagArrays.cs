using System;
using System.Linq;

class ZigZagArrays
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string[] firstArr = new string[num];
        string[] secondArr = new string[num];
        string[] myArr;
        bool check = true;

        for (int i = 0; i < num; i++)
        {
            myArr = Console.ReadLine().Split().ToArray();
            if (check == true)
            {
                firstArr[i] = myArr[0];
                secondArr[i] = myArr[1];
                check = false;
            }
            else
            {
                firstArr[i] = myArr[1];
                secondArr[i] = myArr[0];
                check = true;
            }
        }
        for (int i = 0; i < num; i++)
        {
            Console.Write($"{firstArr[i]} ");
        }
        Console.WriteLine();
        for (int i = 0; i < num; i++)
        {
            Console.Write($"{secondArr[i]} ");
        }
    }
}