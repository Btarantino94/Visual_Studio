using System;

class Program
{
    static void Main()
    {
        // Divide the first number by the second number.
        int operand1 = 100;
        int operand2 = 345;

        // Incorrect division for double:
        double number1 = operand1 / operand2;
        Console.WriteLine(number1);

        // Correct division for double:
        double number2 = (double)operand1 / operand2;
        Console.WriteLine(number2);

        // Incorrect division for double:
        double number3 = (double)(operand1 / operand2);
        Console.WriteLine(number3);

        // Correct division for double:
        double number4 = (double)operand1 / (double)operand2;
        Console.WriteLine(number4);

        // Correct division for double:
        double number5 = operand1 / (double)operand2;
        Console.WriteLine(number5);
    }
}
