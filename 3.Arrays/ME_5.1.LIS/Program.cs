using System;
using System.Collections.Generic;
using System.Linq;

class LIS2
{
    static void Main(string[] args)
    {


        List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> finalList = new List<int>();
        List<int> tempList = new List<int>();
        List<int> maxList = new List<int>();
        List<int> tempListCheck = new List<int>();
        int count = 1;
        int countMax = 0;

        int check = int.MinValue;
        int last = 1;

        for (int i = 0; i < inputList.Capacity; i++)
        {
            finalList.Add(inputList[i]);

            tempList = inputList.ToList();
            check = tempList[i];
            tempList.Remove(tempList[0]);

            while (tempList.Min() <= check)
            {
                finalList.Add(tempList.Min());
                check = tempList.Min();
                tempList.Remove(tempList.Min());
            }

            Console.WriteLine();
        }
    }
}