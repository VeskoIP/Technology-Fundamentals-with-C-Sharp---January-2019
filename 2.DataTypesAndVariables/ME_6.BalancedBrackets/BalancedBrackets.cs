using System;

class BalancedBrackets
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        string str = null;
        int counter = 0;
        bool check = true;

        for (int i = 0; i < lines; i++)
        {
            str = Console.ReadLine();
            if (str == "(" && counter == 0)
            {
                counter++;
            }

            else if (str == "(" && counter != 0)
            {
                check = false;
            }

            else if (str == ")" && counter == 1)
            {
                counter = 0;
            }

            else if (str == ")" && counter != 1)
            {
                check = false;
            }
        }

        if (check == true && counter == 0)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}