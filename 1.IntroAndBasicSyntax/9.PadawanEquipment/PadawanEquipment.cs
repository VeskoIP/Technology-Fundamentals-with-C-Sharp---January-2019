using System;

class PadawanEquipment
{
    static void Main()
    {
        double amountOfMoney = double.Parse(Console.ReadLine());
        int countOfStudents = int.Parse(Console.ReadLine());
        double priceOfLightsabers = double.Parse(Console.ReadLine());
        double priceOfRobes = double.Parse(Console.ReadLine());
        double priceOfBelt = double.Parse(Console.ReadLine());
        double sum = 0;

        priceOfLightsabers = Math.Ceiling(countOfStudents * 1.1) * priceOfLightsabers;
        priceOfBelt = (countOfStudents - Math.Floor(countOfStudents / 6.0)) * priceOfBelt;
        priceOfRobes = countOfStudents * priceOfRobes;
        sum = priceOfLightsabers + priceOfBelt + priceOfRobes;

        if ((amountOfMoney - sum) >= 0)
        {
            Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
        }

        else
        {
            Console.WriteLine($"Ivan Cho will need {(sum - amountOfMoney):F2}lv more.");
        }
    }
}