using System;
using System.Linq;

class LadyBugs
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] intputIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] ladyBugsIndexes = new int[fieldSize];

        for (int i = 0; i < intputIndexes.Length; i++)
        {
            if (intputIndexes[i] < fieldSize && intputIndexes[i] >= 0)
            {
                ladyBugsIndexes[intputIndexes[i]] = 1;
            }
        }

        string input = Console.ReadLine();
        string[] myArr;

        int bugPosition = 0;
        int bugMove = 0;


        while (input != "end")
        {
            myArr = input.Split().ToArray();
            bugPosition = int.Parse(myArr[0]);
            string direction = myArr[1];
            bugMove = int.Parse(myArr[2]);


            if (direction == "right")
            {
                if (bugPosition < fieldSize && bugPosition >= 0 && ladyBugsIndexes[bugPosition] == 1)
                {
                    ladyBugsIndexes[bugPosition] = 0;
                    bugPosition += bugMove;

                    while (bugPosition < fieldSize && bugPosition >= 0 && ladyBugsIndexes[bugPosition] == 1)
                    {
                        bugPosition += bugMove;
                    }
                    if (bugPosition < fieldSize && bugPosition >= 0)
                    {
                        ladyBugsIndexes[bugPosition] = 1;
                    }
                }
            }
            else
            {
                if (bugPosition < fieldSize && bugPosition >= 0 && ladyBugsIndexes[bugPosition] == 1)
                {
                    ladyBugsIndexes[bugPosition] = 0;
                    bugPosition -= bugMove;

                    while (bugPosition < fieldSize && bugPosition >= 0 && ladyBugsIndexes[bugPosition] == 1)
                    {
                        bugPosition -= bugMove;
                    }
                    if (bugPosition < fieldSize && bugPosition >= 0)
                    {
                        ladyBugsIndexes[bugPosition] = 1;
                    }
                }
            }

            input = Console.ReadLine();
        }

        for (int i = 0; i < fieldSize; i++)
        {
            Console.Write($"{ladyBugsIndexes[i]} ");
        }
    }
}