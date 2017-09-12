using System;

namespace Task3
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

            if (evaluatedNumber > 0)
            {
                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine("Number {0} is positive and even", evaluatedNumber);
                }
                else
                {
                    Console.WriteLine("Number {0} is positive and odd", evaluatedNumber);
                }
            }
            else if (evaluatedNumber < 0)
            {
                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine("Number {0} is negative and even", evaluatedNumber);
                }
                else
                {
                    Console.WriteLine("Number {0} is negative and odd", evaluatedNumber);
                }
            }
            else
            {
                Console.WriteLine("Number {0} is zero and even", evaluatedNumber);
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
