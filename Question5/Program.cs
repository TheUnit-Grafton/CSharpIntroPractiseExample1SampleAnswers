using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            string firstName;
            string middleName;
            string lastName;
            string initials;

            // Get First, Middle and Last names
            Console.WriteLine("What is your First Name? ");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your Middle Name? ");
            middleName = Console.ReadLine();

            Console.WriteLine("What is your Last Name?");
            lastName = Console.ReadLine();


            // Get initials from each name
            var Initials = firstName.Substring(0, 1);

            // Check to see if there is a middle name.
            // If so, get the initial, otherwise do nothing
            if (string.IsNullOrWhiteSpace(middleName) == false)
            {
                Initials += middleName.Substring(0, 1);
            }

            // Add initial for last name
            Initials += lastName.Substring(0, 1);

            // Display Initials
            Console.WriteLine();
            Console.WriteLine($"Your initials are: {Initials.ToUpper()}");
            Console.WriteLine();
        }
    }
}
