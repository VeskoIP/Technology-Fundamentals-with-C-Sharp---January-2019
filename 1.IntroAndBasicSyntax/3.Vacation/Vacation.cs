using System;

class Vacation
{
    static void Main()
    {
        int group = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string day = Console.ReadLine();
        double price = 0;

        switch (type)
        {
            case "Students":
                {
                    switch (day)
                    {
                        case "Friday": price = 8.45; break;
                        case "Saturday": price = 9.8; break;
                        case "Sunday": price = 10.46; break;
                    }
                }
                break;

            case "Business":
                {
                    switch (day)
                    {
                        case "Friday": price = 10.90; break;
                        case "Saturday": price = 15.60; break;
                        case "Sunday": price = 16; break;
                    }
                }
                break;

            case "Regular":
                {
                    switch (day)
                    {
                        case "Friday": price = 15; break;
                        case "Saturday": price = 20; break;
                        case "Sunday": price = 22.5; break;
                    }
                }
                break;
        }

        if (group >= 30 && type == "Students")
        {
            price = (price * group) * 0.85;
        }

        else if (group >= 100 && type == "Business")
        {
            price = (price * group) - (price * 10);
        }

        else if (group >= 10 && group <= 20 && type == "Regular")
        {
            price = (price * group) * 0.95;
        }

        else
        {
            price = price * group;
        }

        Console.WriteLine($"Total price: {price:F2}");
    }
}