using System;

namespace Task4
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

            

            // Wait for user input
            Console.ReadKey();
        }
    }
}
