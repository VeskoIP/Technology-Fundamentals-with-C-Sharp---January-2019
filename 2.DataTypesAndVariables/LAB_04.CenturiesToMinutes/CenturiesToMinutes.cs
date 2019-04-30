using System;

class CenturiesToMinutes
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());

        double years = 100 * centuries;
        int days = (int)(years * 365.2422);
        double hours = days * 24;
        double minutes = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}