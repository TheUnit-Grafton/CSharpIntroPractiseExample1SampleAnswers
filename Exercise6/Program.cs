using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Which numbers?");
            Console.WriteLine();
            Console.WriteLine("Please enter your first number: ");
            var input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.WriteLine("Please enter your second number: ");
            input = Console.ReadLine();
            num2 = int.Parse(input);
            Console.WriteLine();
            Console.WriteLine($"Multiplying {num1} and {num2} gives  result of: {num1 * num2}");
        }
    }
}
