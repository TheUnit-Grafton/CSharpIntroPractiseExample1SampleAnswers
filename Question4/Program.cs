using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initalize needed vriables
            int num1;
            int num2;
            int additionTotal;
            int subtractionTotal;
            int multiplyTotal;

            // Results of a divide operation should be a double
            // data type to allow dor a decimal point in the answer.
            double divideTotal = 0.0f;

            // Get the user to enter 2 numbers
            Console.WriteLine("Enter your first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            num2 = int.Parse(Console.ReadLine());

            // Perform all the calculations
            additionTotal = num1 + num2;
            subtractionTotal = num1 - num2;
            multiplyTotal = num1 * num2;

            // Only perform the division if the first number is larger that the second number
            if (num1 != 0 && num2 != 0)
            {
                divideTotal = num1 / num2;
            }
            // Show result of Addition
            Console.WriteLine();
            Console.WriteLine("The calculated results are:");
            Console.WriteLine($"{num1} + {num2} = {additionTotal}");

            // Show result of subtraction
            Console.WriteLine($"{num1} - {num2} = {subtractionTotal}");

            // Show result of Multiplication
            Console.WriteLine($"{num1} * {num2} = {multiplyTotal}");

            // Show result of Division.
            // NOTE: Check for Divide By Zero errors.
            if (divideTotal != 0)
            {
                Console.WriteLine($"{num1} / {num2} = {divideTotal}");

            }
            else
            {
                Console.WriteLine("Unable to perform division calculation if one number is 0");
            }
            {

            }
        }
    }
}
