using System;

namespace E_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.WriteLine("Please enter a number?");
                    var number = Convert.ToInt32(Console.ReadLine());

                    if (number < 10)
                    {
                        Console.WriteLine("The number is too small!");
                    }
                    else
                    {
                        Console.WriteLine("This number is big");
                    }

                }
            }
        }
    }
}
}
//EASY: Create a program that asks the user to enter an integer.
//If the integer is less than 10, print the message "This number is too small".
//If the integer is greater than or equal to 10, print "This number is big enough".  
//Hint: read a line and then use Int32.TryParse() to convert the text to an integer.
