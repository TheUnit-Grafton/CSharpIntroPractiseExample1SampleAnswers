using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            // Add variable to store 3rd number
            int num3;

            Console.WriteLine("Which numbers?");
            Console.WriteLine();
            Console.WriteLine("Please enter your first number: ");
            var input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.WriteLine("Please enter your second number: ");
            input = Console.ReadLine();
            num2 = int.Parse(input);

            // Accept third number as input from the user
            Console.WriteLine("Please enter your third number: " );
            input = Console.ReadLine();
            num3 = int.Parse(input);
            Console.WriteLine();

            // Declare variable to hold the sum of hte three numbers
            int total = num1 + num2 + num3;

            // Modify final line to report on 3 numbers entered.
            Console.WriteLine($"The numbers you entered were {num1}, {num2} and {num3}.");
            Console.WriteLine($"The sum of these numbers is: {total}");
        }
    }
}
