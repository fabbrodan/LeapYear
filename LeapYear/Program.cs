using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int userYear = 0;
            int currentYear = DateTime.Today.Year;
            bool loop = false;

            do
            {
                if (loop)
                {
                    loop = false;
                }

                Console.WriteLine("Please enter a past year...");
                try
                {
                    userYear = Int32.Parse(Console.ReadLine());

                    if (userYear >= currentYear)
                    {
                        Console.WriteLine("That is not past year.");
                        loop = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a proper year.\n\rPlease write it as a number.");
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
