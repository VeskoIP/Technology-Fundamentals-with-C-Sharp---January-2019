using System;
using System.Linq;

class EncryptSortAndPrintArray
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string name = null;
        char[] vowels = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
        int[] myArr = new int[num];
        int count = 0;
        int sum = 0;

        for (int i = 0; i < num; i++)
        {
            sum = 0;
            count = 0;
            name = Console.ReadLine();

            foreach (char item in name)
            {
                if (vowels.Contains(item))
                {
                    sum = sum + (int)name[count] * name.Length;
                }
                else
                {
                    sum = sum + (int)name[count] / name.Length;
                }
                count++;
            }

            myArr[i] = sum;
        }

        Array.Sort(myArr);

        foreach (int item in myArr)
        {
            Console.WriteLine(item);
        }
    }
}