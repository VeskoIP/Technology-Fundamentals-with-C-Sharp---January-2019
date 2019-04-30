using System;
using System.Text;

class FromLeftToTheRight
{
    static void Main()
    {
        int numLines = int.Parse(Console.ReadLine());

        string str = null;

        string leftNum = null;
        long leftNumInt = 0;
        long leftSum = 0;

        string rightNum = null;
        long rightNumInt = 0;
        long rightSum = 0;

        int count = 0;
        char ch;


        StringBuilder sb = new StringBuilder();
        for (int m = 0; m < numLines; m++)
        {
            str = Console.ReadLine();
            count = 0;
            leftSum = 0;
            rightSum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                ch = str[i];
                if (ch != ' ')
                {
                    sb.Append(ch);
                    if (ch != '-')
                    {
                        leftSum += (int)Char.GetNumericValue(str[i]);
                    }
                    count++;
                }
                else
                {
                    break;
                }
            }
            leftNum = sb.ToString();
            leftNumInt = long.Parse(leftNum);

            sb.Clear();
            for (int i = count + 1; i < str.Length; i++)
            {
                ch = str[i];
                sb.Append(ch);
                if (ch != '-')
                {
                    rightSum += (int)Char.GetNumericValue(str[i]);
                }
            }

            rightNum = sb.ToString();
            rightNumInt = long.Parse(rightNum);
            sb.Clear();

            if (leftNumInt > rightNumInt)
            {
                Console.WriteLine(leftSum);
            }
            else
            {
                Console.WriteLine(rightSum);
            }
        }
    }
}