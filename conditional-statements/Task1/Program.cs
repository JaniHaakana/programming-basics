using System;

namespace Task1
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

            if(evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is greater than 0", evaluatedNumber);
            }
            else if(evaluatedNumber < 0)
            {
                Console.WriteLine("Number {0} is less than 0", evaluatedNumber);
            }
            else
            {
                Console.WriteLine("Number {0} equals 0", evaluatedNumber);
            }

            // Wait for user input
            Console.ReadKey(); 
        }
    }
}
