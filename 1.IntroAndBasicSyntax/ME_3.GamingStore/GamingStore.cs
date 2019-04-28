using System;

class GamingStore
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        double startBalance = balance;
        string game = Console.ReadLine();
        bool check = true;
        double price = 0;

        while (game != "Game Time")
        {
            price = 0;
            switch (game)
            {
                case "OutFall 4": price = 39.99; break;
                case "CS: OG": price = 15.99; break;
                case "Zplinter Zell": price = 19.99; break;
                case "Honored 2": price = 59.99; break;
                case "RoverWatch": price = 29.99; break;
                case "RoverWatch Origins Edition": price = 39.99; break;
            }

            if (price == 0)
            {
                Console.WriteLine("Not Found");
            }

            else if (price > balance)
            {
                Console.WriteLine("Too Expensive");
            }

            else if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                check = false;
                break;
            }

            else
            {
                Console.WriteLine($"Bought {game}");
                balance = balance - price;
            }

            game = Console.ReadLine();
        }

        if (check != false && balance != 0)
        {
            Console.WriteLine($"Total spent: ${startBalance - balance:F2}. Remaining: ${balance:F2}");
        }

        else
        {
            Console.WriteLine("Out of money!");
        }
    }
}