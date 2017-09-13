using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please input corresponding number if you're: \n1. Mtk-jasen\n2. Opiskelija\n3. Mtk-jasen ja Opiskelija\n4. Varusmies\n5. None of the above\n");

            // Read user input
            String userInput;
            userInput = Console.ReadLine();

            //Evaluate user input
            int evaluatedNumber1;
            int.TryParse(userInput, out evaluatedNumber1);

            // Prompt user
            Console.Write("Please enter your age: ");

            userInput = Console.ReadLine();

            //Evaluate user input
            int evaluatedNumber2;
            int.TryParse(userInput, out evaluatedNumber2);

            if (evaluatedNumber1 == 1)
            {
                Console.WriteLine("Ticket price is 13,60e");
            }

            else if (evaluatedNumber1 == 2)
            {
                Console.WriteLine("Ticket price is 7,20e");
            }

            else if (evaluatedNumber1 == 3)
            {
                Console.WriteLine("Ticket price is 6,40e");
            }

            else if (evaluatedNumber1 == 4)
            {
                Console.WriteLine("Ticket price is 8,00e");
            }

            else if (evaluatedNumber1 == 5)
            {
                if (evaluatedNumber2 < 7)
                {
                    Console.WriteLine("Ticket is free");
                }
                else if (evaluatedNumber2 < 15)
                {
                    Console.WriteLine("Ticket price is 8,00e");
                }
                else if(evaluatedNumber2 > 65)
                {
                    Console.WriteLine("Ticket price is 8,00e");
                }
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
