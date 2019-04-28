using System;

class StudentInformation
{
    static void Main()
    {
        string name = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
    }
}