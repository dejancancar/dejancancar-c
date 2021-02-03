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
            string inputFile = Console.ReadLine();
            Console.Write("How many lines of text (max) should there be in the split files? ");
            int thisManyLines = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            



        }
    }
}
