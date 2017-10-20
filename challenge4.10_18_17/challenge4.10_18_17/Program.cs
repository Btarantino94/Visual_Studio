using System;

namespace CHALLENGEtwo
{
    class Cars
    {
        public int numTires, year;
        public string model;
        // Default constructor:
        public Cars()
        {
            numTires = 4;
            year = 2017;
            model = "chevy";
        }

        // A constructor with two arguments:
        public Cars(int numTires, int year, string model)
        {
            this.numTires = numTires;
            this.year = year;
            this.model = model;
        }

        // Override the ToString method:
        public override string ToString()
        {
            return (String.Format("({0},{1},{2})", numTires, year, model));
        }
    }

    class MainClass
    {
        static void Main()
        {
            Cars p1 = new Cars();
            Cars p2 = new Cars();
            Cars p3 = new Cars();

            // Display the results using the overriden ToString method:
            Console.WriteLine("Dream car has {0}", p1);
            Console.WriteLine("Hate this car at {0}", p2);
            Console.WriteLine("This car is okay I guess #3 at {0}", p3);
            Console.ReadKey();
        }
    }
}
//Make a class Vehicle with the properties Type, NumberOfTires, Year, and Model.
//Then write a constructor that takes in those 4 properties as parameters and sets the values of the properties.
//Once your constructor is complete create two instances of Vehicle, the first one should be your dream car and 
//the second should be your i would hate car. Finally display the model of your dream car and the model of your hate car.