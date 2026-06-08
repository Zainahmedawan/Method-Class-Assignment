// Import the System namespace so Console methods can be used.
using System;

namespace MethodClassAssignment
{
    // Create a class named MathOperations.
    public class MathOperations
    {
        // Create a void method that accepts two integer parameters.
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a mathematical operation on the first integer.
            int result = firstNumber + 10;

            // Display the result of the mathematical operation.
            Console.WriteLine("Result of first number + 10: " + result);

            // Display the second integer to the screen.
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}
