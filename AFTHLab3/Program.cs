using System;

namespace AFTHLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Welcome! Please enter your name.");
            string name = Console.ReadLine();


            bool goOn = true;
            while (goOn == true)
            {
                // Get user input
                Console.WriteLine($"Hello {name} please enter a number between 1 and 100 ? ");



                int input = int.Parse(Console.ReadLine());


                // Use Modulus Operator to check for even/odd integar

                bool even = input % 2 == 0;
                bool odd = input % 2 == 1;

                // check ranges
                bool range = input >= 2 && input <= 24;
                bool range1 = input >= 26 && input <= 59;
                bool range2 = input >= 60;


                // Conditional Statements
                if (odd)
                {
                    Console.WriteLine(input + " " + "is an odd number");
                }
                else if (even && range)
                {
                    Console.WriteLine("This is an even number and less than 25");

                }
                else if (even && range1)
                {
                    Console.WriteLine("This is an even number");
                }
                else if (even && range2)
                {
                    Console.WriteLine(input + " " + " is an even number");
                }
                else if (odd & range2)
                {
                    Console.WriteLine(input + " " + "is an odd number");
                }

                //Continue Loop
                while (true)
                {
                    Console.WriteLine($"Would you like to continue {name}? y/n");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "y")
                    {
                        goOn = true;
                        break;
                    }
                    else if (answer.ToLower() == "n")
                    {
                        Console.WriteLine("Good Bye!");
                        goOn = false;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Im sorry I didnt understand that lets try again");
                    }
                }


            }



        }
    }
}
