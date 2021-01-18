using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                //Prompt user to enter a number
                Console.Write("Please enter a Fibanocci number: ");
                string input = Console.ReadLine();
                
                int finalNumber = int.Parse(input); //input converted from string to int

                int leftNumber = 0; //a
                int rightNumber = 1; //b
                                  //int i = 1; //sum of something check back
                                  //int totalAdded = sumInLoop 
                int totalSum = 0; //c
                                  //write loop to check if the display number is lower then user input

                Console.Write(leftNumber +", " +rightNumber);
                for (int i = 1; i <= finalNumber; i += leftNumber) //0, 1, 1, 2, 3, 5, 8, 13
                                                            //loop needs to add variables and  variable totals
                {
                        totalSum = rightNumber + leftNumber;
                        Console.Write(", " + totalSum);
                        leftNumber = rightNumber;
                        rightNumber = totalSum;
                        

                }
                Console.WriteLine();
                Console.WriteLine("To try again press return or type Q to quit!");
                string quit = Console.ReadLine();
                // have 3rd variable for total 

                // add 3rd variable and total for line

                //


                //print out all the numbers up to input number


                // loop entire sequence unless user types q
                if (quit == "Q" || quit == "q")
                {
                    break;
                }


            }
        }

    }
}
