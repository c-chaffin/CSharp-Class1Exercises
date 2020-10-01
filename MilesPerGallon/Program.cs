using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven;
            double gallons;
            double milesPerGallon;
            string input;

            Console.WriteLine("How many miles did you drive?");
            input = Console.ReadLine();
            milesDriven = double.Parse(input);

            Console.WriteLine("How many gallons of gas did you consume?");
            input = Console.ReadLine();
            gallons = double.Parse(input);

            milesPerGallon = milesDriven / gallons;
            Console.WriteLine("Your miles per gallon is " + milesPerGallon);

        }
    }
}
