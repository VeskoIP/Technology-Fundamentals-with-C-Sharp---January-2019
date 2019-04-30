using System;

class Elevator
{
    static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        Console.WriteLine((int)Math.Ceiling((double)numberOfPeople / capacity));
    }
}