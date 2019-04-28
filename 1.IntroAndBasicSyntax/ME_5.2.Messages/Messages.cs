using System;
using System.Text;

class Messages
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string input = null;
        int numOfDigit = 0;
        int mainDigit = 0;
        int offset = 0;
        int letterIndex = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < num; i++)
        {
            input = Console.ReadLine();
            numOfDigit = input.Length;
            mainDigit = Int32.Parse(input[0].ToString());

            if (mainDigit == 0)
            {
                sb.Append(" ");
            }

            else
            {
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = ((mainDigit - 2) * 3) + 1;
                }

                else
                {
                    offset = (mainDigit - 2) * 3;
                }
                letterIndex = offset + numOfDigit - 1;
                sb.Append((char)(97 + letterIndex));
            }
        }

        Console.WriteLine(sb);
    }
}