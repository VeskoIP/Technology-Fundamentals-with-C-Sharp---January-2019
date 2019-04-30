using System;
using System.Collections.Generic;
using System.Linq;

class LIS
{
    static void Main(string[] args)
    {
        List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> finalList = new List<int>();
        List<int> tempList = new List<int>();
        List<int> maxList = new List<int>();
        List<int> tempListCheck = new List<int>();
        int count = 1;
        int countMax = 0;

        for (int i = 0; i < intList.Count; i++)
        {
            finalList.Add(intList.Max());

            for (int m = 0; m <= intList.IndexOf(intList.Max()); m++)
            {
                tempList.Add(intList[m]);
            }

            while (tempList.IndexOf(tempList.Max()) != 0)
            {
                tempList.Remove(tempList.Max());
                tempListCheck = tempList.ToList();
                tempList.Clear();
                for (int m = 0; m <= tempListCheck.IndexOf(tempListCheck.Max()); m++)
                {
                    tempList.Add(intList[m]);
                }


                if (tempList.IndexOf(tempList.Max()) == 0)
                {
                    finalList.Add(tempList.Max());
                    count++;
                    break;
                }

                if (tempList.Max() != finalList.Min())
                {
                    finalList.Add(tempList.Max());
                    count++;
                }
            }

            if (count > countMax)
            {
                maxList.Clear();
                maxList = finalList.ToList();
                countMax = count;
            }

            finalList.Clear();
            tempList.Clear();
            intList.Remove(intList.Max());
            count = 1;
        }

        for (int i = maxList.Capacity - 1; i >= 0; i--)
        {
            Console.Write($"{maxList[i]} ");
        }
    }
}