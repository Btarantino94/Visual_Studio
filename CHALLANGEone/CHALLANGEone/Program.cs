﻿using System;

namespace CHALLANGEone
{
    class PassingValByVal
    {
        static void SquareIt(int x)
        // The parameter x is passed by value.
        // Changes to x will not affect the original value of x.
        {
            x *= x;
            System.Console.WriteLine("The value inside the method: {0}", x);
        }
        static void Main()
        {
            int n = 5;
            System.Console.WriteLine("The value before calling the method: {0}", n);

            SquareIt(n);  // Passing the variable by val.
            System.Console.WriteLine("The value after calling the method: {0}", n);

            // console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        //Write a method that divides two numbers(provided as parameters). 
        //Tip: you will need to use the modifiers public and static. 

    }
}
