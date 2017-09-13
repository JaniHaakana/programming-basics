using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter a number 1:");

            // Read user input
            String userInput;
            userInput = Console.ReadLine();

            //Evaluate user input
            int evaluatedNumber1;
            int.TryParse(userInput, out evaluatedNumber1);

            // Prompt user
            Console.Write("Please enter a number 2:");

            userInput = Console.ReadLine();

            //Evaluate user input
            int evaluatedNumber2;
            int.TryParse(userInput, out evaluatedNumber2);

            // Prompt user
            Console.Write("Please enter a number 3:");

            userInput = Console.ReadLine();

            //Evaluate user input
            int evaluatedNumber3;
            int.TryParse(userInput, out evaluatedNumber3);


            if (evaluatedNumber1 > evaluatedNumber2)
            {
                if (evaluatedNumber1 > evaluatedNumber3)
                {
                    if (evaluatedNumber2 > evaluatedNumber3)
                    {
                        Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber3, evaluatedNumber2, evaluatedNumber1);
                    }
                    else
                    {
                        Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber2, evaluatedNumber3, evaluatedNumber1);
                    }
                }
                else
                {
                    Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber2, evaluatedNumber1, evaluatedNumber3);
                }
            }

            else if (evaluatedNumber2 > evaluatedNumber1)
            {
                if (evaluatedNumber2 > evaluatedNumber3)
                {
                    if (evaluatedNumber3 > evaluatedNumber1)
                    {
                        Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber1, evaluatedNumber3, evaluatedNumber2);
                    }
                    else
                    {
                        Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber3, evaluatedNumber1, evaluatedNumber2);
                    }  
                }
                else
                {
                    Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber1, evaluatedNumber2, evaluatedNumber3);
                }
            }

            else if (evaluatedNumber3 > evaluatedNumber1)
            {
                if (evaluatedNumber3 > evaluatedNumber2)
                {
                    if (evaluatedNumber1 > evaluatedNumber2)
                    {
                        Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber2, evaluatedNumber1, evaluatedNumber3);
                    }
                    else
                    {
                        Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber1, evaluatedNumber2, evaluatedNumber3);
                    }                   
                }
                else
                {
                    Console.WriteLine("1. Number {0} \n2. Number {1} \n3. Number {2}", evaluatedNumber1, evaluatedNumber3, evaluatedNumber2);
                }
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
