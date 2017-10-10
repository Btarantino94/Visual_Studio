using System;

public class Program
{
    public static void Main()
    {
        int rows = 6;

        for (int i = 1; i <= rows; i++)
        {
            String spaces = new string(' ', rows - i);
            String chars = new string('*', (i * 2) - 1);

            Console.WriteLine(spaces + chars);
        }
    }
}

//HARD: Print a Pyramid  
//	*
// ***
// *****
//*******
//*********
//Hints: You can use three loops.The big one contains two smaller loops.The first inner loops takes care of the # of spaces. The second inner loop handles the # of stars. 