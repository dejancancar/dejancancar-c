using System;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {


            //Ask user for their name
            Console.Write("Hello, what is your name? "); // writes line to console. writeline = next line, console.write = same line

            //Get the user's name
            string name = Console.ReadLine(); // string stores the value of name from readline to name or other specified variable
                                              // waits until you hit return or enter in the console

            //Greet the user
            Console.WriteLine($"Well hello there, {name}!");

            //Ask for height
            Console.Write("How tall are you in inches? ");
            //Read height from user input on console
            string heightAsString = Console.ReadLine(); // need empty (); so user can input data
            int heightInches = int.Parse(heightAsString); //Parse means to pick out   starts as string, asigns int to new string from string


            // calculate feet and inches
            int feet = heightInches / 12;
            int inches = heightInches % 12;

            Console.WriteLine($"Wow did you know that is {feet} feet and {inches} inches.");

            //Ask if the user is wearing flannel
            Console.Write("Are you wearing flannel right? (true / false) ");
            string input = Console.ReadLine();
            bool isWearingFlannel = bool.Parse(input); // same as line 22 & 23 combined
            //If wearing flannel and they are over 6 feet, they look like a lumber jack.
            if (isWearingFlannel)
            {
                Console.WriteLine("Thanks for participating!");
            }
            else
            {
                //throw new Exception("You Stink!"); //Purposely making the program crash with Exception
                Console.WriteLine("Maybe next week!");
            }


            //Ask the user for a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            //Split the sentence into words, and print one word on each line
            string[] words = sentence.Split(" "); // changes variable sentence to string called words
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            string newSentence = string.Join("-", words); // joins array words with - or whatever charachter you decide, to new string newSentence
            Console.WriteLine(newSentence);// writes new sentence


            while (true) // true can be ANY boolean name does not have to be true
            {

             //Ask for a series of comma seperated numbers, add them up and tell the user the total.
            
             //Prompt user for comma serperated numbers
             Console.WriteLine("Enter a series of comma-seperated numbers (Q to quit): ");
             string input = Console.ReadLine();
             //Did the user type Q?
             if (input == "Q")
                {
                    //Break out of the loop
                    break;
                }
             //Split the string into an array of string numbers
             string[] stringNumbers = input.Split(",");
             //initialize a sum to 0
             int sum = 0;
             //loop through the array of string numbers 
             for (int i = 0; i < stringNumbers.Length; i++)
             {
                //Parse the element into an int
                int num = int.Parse(stringNumbers[i]);
                // add the value to the sum 
                sum += num;
             }


                //Once the loop is finished, tell the user the sum

                Console.WriteLine($"Those numbers added up to a total of {sum}!");
        } Console.WriteLine("Good bye!");  }
             
    }
}
