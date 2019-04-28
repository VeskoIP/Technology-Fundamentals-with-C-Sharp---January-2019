using System;

class VendingMachine
{
    static void Main()
    {
        string input = Console.ReadLine();
        double coins = 0;
        double moneySum = 0;
        double price = 0;
        double bill = 0;
        bool check = true;

        while (input != "Start")
        {
            coins = double.Parse(input);

            if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
            {
                moneySum += coins;
            }

            else
            {
                Console.WriteLine($"Cannot accept {coins}");
            }

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "End")
        {
            switch (input)
            {
                case "Nuts": price = 2.0; break;
                case "Water": price = 0.7; break;
                case "Crisps": price = 1.5; break;
                case "Soda": price = 0.8; break;
                case "Coke": price = 1.0; break;

                default:
                    {
                        Console.WriteLine("Invalid product");
                        check = false;
                    };
                    break;
            }

            bill += price;

            if (bill > moneySum)
            {
                Console.WriteLine("Sorry, not enough money");
                bill = bill - price;
            }

            else
            {
                if (check == true)
                {
                    input = input.ToLower();
                    Console.WriteLine($"Purchased {input}");
                }

                else
                {
                    check = true;
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Change: {(moneySum - bill):F2}");
    }
}