using System;
using System.Globalization;

class MonthPrinter
{
    static void Main()
    {
        int month = int.Parse(Console.ReadLine());
        DateTime monthName = new DateTime(month);

        if (month >= 1 && month <= 12)
        {
            monthName = monthName.AddMonths(month - 1);
            Console.WriteLine(monthName.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US")));
        }

        else
        {
            Console.WriteLine("Error!");
        }
    }
}