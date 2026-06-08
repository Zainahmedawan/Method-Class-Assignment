// Import the System namespace.
using System;

namespace MethodClassAssignment
{
    // Main program class.
    class Program
    {
        // Application entry point.
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class.
            MathOperations mathOps = new MathOperations();

            // Call the method using positional parameters.
            mathOps.PerformOperation(15, 25);

            // Display a blank line for readability.
            Console.WriteLine();

            // Call the method again using named parameters.
            mathOps.PerformOperation(firstNumber: 30, secondNumber: 40);

            // Pause the console window until the user presses Enter.
            Console.ReadLine();
        }
    }
}
