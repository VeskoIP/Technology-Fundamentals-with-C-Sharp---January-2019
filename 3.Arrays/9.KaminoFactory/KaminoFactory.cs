using System;
using System.Linq;

class KaminoFactory
{
    static void Main()
    {
        int dnaLenght = int.Parse(Console.ReadLine());
        string sequence = Console.ReadLine();
        int[] myArr;
        int[] outputArr = new int[dnaLenght];
        int counter = 0;
        int count = 0;
        int outputCount = 0;
        int lenght = 0;
        int maxLenght = 0;
        int position = 1;
        int outputPosition = 1;
        int sum = 0;
        int maxSum = 0;

        while (sequence != "Clone them!")
        {
            count++;
            myArr = sequence.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            counter = 0;
            lenght = 0;
            sum = 0;
            for (int i = 0; i < dnaLenght; i++)
            {
                if (myArr[i] == 1)
                {
                    sum++;
                }
            }

            for (int i = 0; i < dnaLenght; i++)
            {
                if (i != dnaLenght - 1 && myArr[i] == 1)
                {
                    counter++;
                    if (counter > lenght)
                    {
                        lenght = counter;
                        position = i + 1;
                    }
                }

                else if (i != dnaLenght - 1 && myArr[i] != 1)
                {
                    counter = 0;
                }

                else if (i == dnaLenght - 1 && myArr[i] == 1 && lenght == 0)
                {
                    counter++;
                    lenght = counter;
                    position = i + 1;
                }

                else
                {
                    counter = 0;
                }
            }

            if (maxLenght < lenght)
            {
                maxLenght = lenght;
                outputArr = myArr;
                maxSum = sum;
                outputPosition = position;
                outputCount = count;
            }
            else if (maxLenght == lenght)
            {
                if (position < outputPosition)
                {
                    outputArr = myArr;
                    maxSum = sum;
                    outputPosition = position;
                    outputCount = count;
                }
                else if (outputPosition == position)
                {
                    if (sum > maxSum)
                    {
                        outputArr = myArr;
                        maxSum = sum;
                        outputPosition = position;
                        outputCount = count;
                    }
                }
            }

            sequence = Console.ReadLine();
        }

        if (outputCount == 0)
        {
            Console.WriteLine($"Best DNA sample 1 with sum: {maxSum}.");
        }
        else
        {
            Console.WriteLine($"Best DNA sample {outputCount} with sum: {maxSum}.");
        }

        for (int i = 0; i < dnaLenght; i++)
        {
            Console.Write($"{outputArr[i]} ");
        }
    }
}