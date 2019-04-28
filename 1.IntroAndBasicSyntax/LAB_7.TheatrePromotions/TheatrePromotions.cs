using System;

class TheatrePromotions
{
    static void Main()
    {
        string day = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        if (0 <= age && age <= 18)
        {
            switch (day)
            {
                case "Weekday": Console.WriteLine("12$"); break;
                case "Weekend": Console.WriteLine("15$"); break;
                case "Holiday": Console.WriteLine("5$"); break;
            }
        }

        else if (18 < age && age <= 64)
        {
            switch (day)
            {
                case "Weekday": Console.WriteLine("18$"); break;
                case "Weekend": Console.WriteLine("20$"); break;
                case "Holiday": Console.WriteLine("12$"); break;
            }
        }

        else if (64 < age && age <= 122)
        {
            switch (day)
            {
                case "Weekday": Console.WriteLine("12$"); break;
                case "Weekend": Console.WriteLine("15$"); break;
                case "Holiday": Console.WriteLine("10$"); break;
            }
        }

        else
        {
            Console.WriteLine("Error!");
        }
    }
}