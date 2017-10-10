using System;
using Tabata.Models;

namespace Tabata
{
    class Program
    {
        static void Main(string[] args)
        {
            //make application dynamic

            Console.WriteLine("How many sets would you like to complete?");
            int sets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many seconds would you like your work session to run?");
            int work = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many seconds would you like your work session to run?");
            int rest = Convert.ToInt32(Console.ReadLine());

            //pass in our users input which we've made dynamic
            //instaniate our TabataSession model, create a tabataSession object
            //creates new instats of tabataSession below
            tabataSession session = new tabataSession(sets, work, rest);
            //tabataSession sessionTwo = new tabataSession(sets, work, rest);
            //tabataSession sessionThree = new tabataSession(sets, work, rest);

        }
    }
}
