
using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal a, b, c;
            string input;


            Console.Write("Enter the length of the room:");
            input = Console.ReadLine();
            a = Decimal.Parse(input);

            Console.Write("Enter the width of the room:");
            input = Console.ReadLine();
            b = Decimal.Parse(input);

            Console.Write("Enter the overage percent:");
            input = Console.ReadLine();
            c = Decimal.Parse(input);

            Decimal totalarea = (a * b + (c/100 * a * b));

            Console.Write("The total area, including overage, is: " + totalarea);
        }
    }
}

