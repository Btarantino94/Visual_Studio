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
            Console.WriteLine("Cars #1 at {0}", p1);
            Console.WriteLine("Cars #2 at {0}", p2);
            Console.WriteLine("Cars #3 at {0}", p3);
            Console.ReadKey();
        }
    }
}
//Make a class car with the properties numberOfTires = 4, year = 2017, and model = "insert your model of choice", 
//and create three instances of it: car1, car2, and car3.
