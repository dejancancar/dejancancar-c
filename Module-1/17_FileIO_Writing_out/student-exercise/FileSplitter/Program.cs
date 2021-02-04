using System;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            //..\..\..\input.txt

            Console.Write("Where is the input file (please include the path to the file)? ");
            string path = Console.ReadLine(); // input file path
            Console.Write("How many lines of text (max) should there be in the split files? ");
            int thisManyLines = int.Parse(Console.ReadLine());//number of lines max

            //input path into stream reader to read the file

            using (StreamReader reader = new StreamReader(path))
            {
                // use this many lines to run a loop to write a new file
                //need to read from input and add to an input 
         
            }

            //write new file adding 1 to file path name

            //output new files. The output file should have the number of lines the user specified, make new files each time
           



        }
    }
}
