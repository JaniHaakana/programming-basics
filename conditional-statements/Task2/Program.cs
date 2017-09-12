using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter a number:");

            // Read user input
            String userInput;
            userInput = Console.ReadLine();

            //Evaluate user input
            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            if (evaluatedNumber % 2 == 0)
            {
                // Number 0 is considered to be even
                Console.WriteLine("Number {0} is even", evaluatedNumber);
            }
            else
            {
                Console.WriteLine("Number {0} is odd", evaluatedNumber);
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
