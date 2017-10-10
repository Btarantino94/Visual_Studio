using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your guess for the guessing game. Please?");

            while (true)
            {

                try
                {
                    int userInput = Convert.ToInt16(Console.ReadLine());

                    Random random = new Random();
                    int randomNumber = random.Next(1, 20);
                    if (randomNumber == userInput)
                    {
                        Console.WriteLine("Horray, you won!");
                    }
                    else if (userInput > randomNumber)
                    {
                        Console.WriteLine("Your number was way too high");
                    }
                    else if (userInput < randomNumber)
                    {
                        Console.WriteLine("Your number was way too low");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You must enter a valid number;");
            }

        }
    }
}