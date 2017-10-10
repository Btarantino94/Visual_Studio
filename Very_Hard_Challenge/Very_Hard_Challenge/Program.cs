using System;

namespace Very_Hard_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("give number in inches : ");
            int calculating = int.Parse(Console.ReadLine());
            inches(calculating);
            Console.ReadKey();
        }

        private static double inches(int calculating)
        {
            Console.WriteLine(calculating + " inches = " + 2.54 * calculating + " cm");
            return 0;
        }
    }
}
//VERY HARD:  
//Write a program using a switch statement that takes one value from the user and asks about the type of conversion and then performs a conversion depending on the type of conversion.If user enters: 
//I -> convert from inches to centimeters.
//G -> convert from gallons to liters.
//M -> convert from mile to kilometer.
//P -> convert from pound to kilogram.
//If the user enters any other character then show a proper message.

