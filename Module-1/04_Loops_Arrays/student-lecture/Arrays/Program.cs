using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Creating an array of integers
            int[] scores = new int[4];
            scores[0] = 99;
            scores[1] = 67;
            scores[2] = 78;
            scores[3] = 88;

            //How many elements are in the arry?
            Console.WriteLine("There are " + scores.Length + " elements in the array."); //We do this all the time.

            //aside... string interpolation
            Console.WriteLine($"There are {scores.Length} elements in the array.");// $ string interpolation, easier to read and cleaner


            //2. Creating an array of strings
            //declare string    assign memory but compiler figures it on its own   info in array and size
            string[] students = new string[] { "Dejan", "Andrew", "Brandon", "Kameron", "Tim" };

            students[1] = "Drew";

            //3. Create an array of characters that hold "Tech Elevator"        
            char[] characters = new char[] { 'T', 'e', 'c', 'h' };


            //4. Print out the first item in each array

            Console.WriteLine($"The first element is {characters[0]}");

            //Print the LAST element
            Console.WriteLine($"The last element is {characters[characters.Length -1]}");

            //5. Print out the 3rd item [in each array
            

            //6. Get the length of each array

            //7. Get the last index 

            //8. Update the last item in each array

            Console.ReadLine();
        }
    }
}
