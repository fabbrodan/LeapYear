using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int userYear = 0;
            int currentYear = DateTime.Today.Year;

            // bool variable to control the input loop
            bool loop = false;

            // do loop for the user input
            do
            {
                // Reset bool to assume that all is OK
                if (loop)
                {
                    loop = false;
                }

                Console.WriteLine("Please enter a past year...");
                try
                {
                    userYear = Int32.Parse(Console.ReadLine());
                }
                // Check for FormatException on the input to verify that the user has entered a number
                catch (FormatException)
                {
                    Console.WriteLine("That is not a proper year.\n\rPlease write it as a number.");
                    loop = true;
                }

                if (userYear >= currentYear)
                    {
                        Console.WriteLine("That is not past year.");
                        loop = true;
                    }

            } while (loop);

            Console.WriteLine("\n\rHere are all the Leap Years between years {0} and {1}:", userYear, currentYear);

            for (int i = userYear; i < currentYear; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
