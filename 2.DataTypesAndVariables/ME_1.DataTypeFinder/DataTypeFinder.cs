using System;

class DataTypeFinder
{
    static void Main()
    {
        string input = Console.ReadLine();
        int intResult;
        double doubleResult;
        char charResult;
        bool boolResult;

        while (input != "END")
        {
            if (int.TryParse(input, out intResult))
                Console.WriteLine($"{input} is integer type");

            else if (double.TryParse(input, out doubleResult))
                Console.WriteLine($"{input} is floating point type");

            else if (char.TryParse(input, out charResult))
                Console.WriteLine($"{input} is character type");

            else if (bool.TryParse(input, out boolResult))
                Console.WriteLine($"{input} is boolean type");

            else Console.WriteLine($"{input} is string type");

            input = Console.ReadLine();
        }
    }
}