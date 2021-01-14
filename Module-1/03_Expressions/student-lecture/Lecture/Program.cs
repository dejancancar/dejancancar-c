using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*****************************************************************************
            Part 1: Variable Scope
            ******************************************************************************/
            // Declare a variable
            int outerVariable = 100;
            Console.WriteLine("OuterVariable is " + outerVariable);
            // Start a statement block
            {
                Console.WriteLine("Outervariable (from the inner block) = " + outerVariable);

                outerVariable += 1000;
                // Print out the variable defined in the outer scope
                int innerVar = 200;

                // Declare a variable in the block (inner scope)
                Console.WriteLine("InnerVar is " + innerVar);
                // Print out that variable

            // End the statement block
            }

            // Print the the variable declared in the block
            //OOPS CAN'T DO THIS, INNER VAR IS INSIDE BRACKETS, NOT DEFINED OUTSIDE.
            //Console.WriteLine("InnerVar (from outer block) is " + innerVar;
            Console.WriteLine("Outervariable is " + outerVariable);

            /*****************************************************************************
            Part 2: Methods
            ******************************************************************************/
            // Call the MultiplyBy method
            // I have a 10 x 12 room. Calculate its area using MultipleTwoNumbers.
            int length = 12;
            int width = 10;
            int area = MultiplyBy(length, width);
            Console.WriteLine("The area of the room is " + area);
            // Create and print some boolean expressions
            int age = 13;

            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else //Younger than 18
            {
                Console.WriteLine("You are just a kid");
            }
            age = 18;
            // Can I drink or vote?
            if (age < 18)
            {
                Console.WriteLine("You may not drink or vote!");
            }
            else if (age < 21) // Older than 18 but not 21
            {
                Console.WriteLine("You can vote, but you cannot drink!");
            }
            else // Older or equal 21
            {
                Console.WriteLine("You can drink and vote, and this year you should probably drink before you vote!");
            }


            int die = 4;
            //Print out whether this is an even or odd roll
            if (die % 2 == 0)
            {
                Console.WriteLine("Your roll is even!");
            }
            else
            {
                Console.WriteLine("Your roll was odd!");
            }
           

            Console.WriteLine("This is the end");

            // ANother way
            if (die == 2 || die == 4 || die == 6)
            {
                Console.WriteLine("Your roll is even!");
            }
            else
            {
                Console.WriteLine("Your roll was odd!");
            }


            Console.WriteLine("This is the end");
        }

        /*
         * Create a method called MultiplyBy, which takes two integers and returns the integer product.
         */
        static int MultiplyBy(int a, int b)
        {
            int product = a * b;
            return product;
        }
    }
}
