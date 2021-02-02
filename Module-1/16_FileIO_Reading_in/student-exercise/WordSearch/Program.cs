using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                //1. Ask the user for the search string
                Console.Write("Please enter the string you wish to search: ");
                string userInput = Console.ReadLine();

                //2. Ask the user for the file path
                Console.Write("Please enter the path of the file you are trying to search through: ");

                string filePathToSearch = Console.ReadLine();
                Console.WriteLine("Should the search be case sensitive? (Y/N)");
                string caseSensitive = Console.ReadLine();
                //3. Open the file
                if (caseSensitive == "y" || caseSensitive == "Y")
                {
                    int lineNumber = 1;
                    using (StreamReader reader = new StreamReader(Path.GetFullPath(filePathToSearch)))
                    {
                        //4. Loop through each line in the file
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (line.Contains(userInput))
                            {
                                Console.WriteLine($"{lineNumber}) {line}");
                                lineNumber++;
                            }
                            else
                            {
                                lineNumber++;
                            }

                        }
                    }

                }
                else
                {
                    int lineNumber = 1;
                    using (StreamReader reader = new StreamReader(Path.GetFullPath(filePathToSearch)))
                    {
                        //4. Loop through each line in the file
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string lineLower = line.ToLower();
                            if (lineLower.Contains(userInput))
                            {
                                Console.WriteLine($"{lineNumber}) {line}");
                                lineNumber++;
                            }
                            else
                            {
                                lineNumber++;
                            }

                        }
                    }
                }

            }
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}
