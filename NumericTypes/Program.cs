using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input;

            Console.WriteLine("What is the length of the rectangle?");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("What is the width of the rectangle?");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);

        }
    }
}
