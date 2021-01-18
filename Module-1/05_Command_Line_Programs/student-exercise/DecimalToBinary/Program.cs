using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter in a series of decimal values (separated by spaces): ");
                string decimals = Console.ReadLine();
                string[] numbers = decimals.Split(" "); 
                //enter decimal values seperated by spaces
                //save decimal as string
                //read each decimal space and seperate them into an array with the " "

                

                // convert the string to decimal? or convert to a binary
                // print original number and in binary is










                Console.WriteLine();
                Console.WriteLine("To try again press return or type Q to quit!");
                string quit = Console.ReadLine();


                if (quit == "Q" || quit == "q")
                {

                    break;

                }
            }
        }    

    }
}
