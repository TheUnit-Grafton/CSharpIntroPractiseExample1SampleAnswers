using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            double result;
            
            Console.WriteLine("Dividing numbers?");
            Console.WriteLine();
            Console.WriteLine("Please enter your first number: ");
            var input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.WriteLine("Please enter your second number: ");
            input = Console.ReadLine();
            num2 = int.Parse(input);

            if (num1 != 0 && num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine();
                Console.WriteLine($"{num1} divided by {num2} is {result}.");
            }
            else
            {
                Console.WriteLine("You cannot divide by Zero!!");
            }

        }
    }
}
