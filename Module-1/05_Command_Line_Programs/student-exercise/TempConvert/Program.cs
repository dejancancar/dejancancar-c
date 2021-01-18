using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature conversion calculator!");
            while (true)
            {
                

                //Ask user to enter temperature 
                Console.Write("Please enter a temperature: ");
                string tempInput = Console.ReadLine();
                double tempNumber = double.Parse(tempInput); //convert from string to double

                Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");
                string tempType = Console.ReadLine(); //create string to save temp & one to save C OR F


                double tempOutput = 0;
                
                if (tempType == "C" || tempType == "c")
                {
                    tempOutput = (tempNumber * 1.8) + 32;
                    string tempShort = $"{tempOutput:#.##}";
                    Console.WriteLine($"{tempNumber} C is " + tempShort + "F");
                }
                else if (tempType == "F" || tempType == "f")
                {
                    tempOutput = (tempNumber - 32) / 1.8;
                    string tempShort = $"{tempOutput:#.##}";
                    Console.WriteLine($"{tempNumber} F is " + tempShort + "C");
                }

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

            //Tc = (Tf - 32) / 1.8 //converts fahrenheit to celsius

            //Tf = Tc * 1.8 + 32 // converts celsius to fahrenheit


            //Convert temp from one to the other

            //Print out the temperature & include both the inital temp and conversion


        }
    }
}
