using System;

class BackIn30Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        TimeSpan span = new TimeSpan(hours, minutes, 0);

        span = span.Add(TimeSpan.FromMinutes(30));

        Console.WriteLine("{0:h\\:mm}", span);
    }
}