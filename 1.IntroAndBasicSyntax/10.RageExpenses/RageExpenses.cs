using System;

class RageExpenses
{
    static void Main()
    {
        int lostGamesCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double headsetPriceSum = 0;
        double mousePriceSum = 0;
        double keyboardPriceSum = 0;
        double displayPriceSum = 0;
        int keyboardTrashesCount = 0;
        double sum = 0;

        for (int i = 1; i <= lostGamesCount; i++)
        {
            if (i % 2 == 0)
            {
                headsetPriceSum = headsetPriceSum + headsetPrice;
            }

            if (i % 3 == 0)
            {
                mousePriceSum = mousePriceSum + mousePrice;
            }
            if (i % 2 == 0 && i % 3 == 0)

            {
                keyboardPriceSum = keyboardPriceSum + keyboardPrice;
                keyboardTrashesCount++;
            }

            if (keyboardTrashesCount % 2 == 0 && keyboardTrashesCount != 0)
            {
                displayPriceSum = displayPriceSum + displayPrice;
                keyboardTrashesCount = 0;
            }
        }

        sum = headsetPriceSum + mousePriceSum + keyboardPriceSum + displayPriceSum;
        Console.WriteLine($"Rage expenses: {sum:F2} lv.");
    }
}