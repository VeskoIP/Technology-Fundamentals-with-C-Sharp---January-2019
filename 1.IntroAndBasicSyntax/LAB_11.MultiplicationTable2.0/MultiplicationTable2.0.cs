using System;

class MultiplicationTable2
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int times = int.Parse(Console.ReadLine());

        if (times > 10)
        {
            Console.WriteLine($"{num} X {times} = {num * times}");
        }

        else
        {
            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}