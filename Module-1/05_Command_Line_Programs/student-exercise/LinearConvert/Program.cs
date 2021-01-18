using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unit Converter!");
            while (true)
            {

                // meters = f * 0.3048
                //Feet = m * 3.2808399

                //Prompt user to enter length
                Console.Write("Please enter your length: ");
                string lengthInput = Console.ReadLine();
                double numberLength = double.Parse(lengthInput);//Save length and change to int

                //ask if feet or meters
                Console.Write("Is the measurement in (m)eters or (f)eet: ");
                string unitType = Console.ReadLine(); //save string length type

                //variable for conversion total
                double outputLength = 0;
                //if meters convert to feet
                if(unitType == "m" || unitType == "M")
                {
                    outputLength = 3.2808399 * numberLength;
                    string shortOutputLength = $"{outputLength:#.####}";
                    Console.WriteLine($"{numberLength} meters is {shortOutputLength} feet!");
                }
                else if (unitType == "f" || unitType =="F")
                {
                    outputLength = 0.3048 * numberLength;
                    string shortOutputLength = $"{outputLength:#.####}";
                    Console.WriteLine($"{numberLength} feet is {shortOutputLength} feet!");

                }

                //if feet convert to meters

                Console.Write("Press ENTER to try again or type Q to quit! ");

                string quit = Console.ReadLine();
                {
                    if (quit == "q" || quit == "Q")
                    {
                        Console.WriteLine("Good Bye!");
                        break;
                    }
                }
                

            }
        }
    }
}
