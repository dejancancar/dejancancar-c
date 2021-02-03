using System;
using System.Collections.Generic;
using System.IO;


namespace FizzWriter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //write file fizzbuzz.txt to student exercise

            //If the number is divisible by 3 or contains a 3, print “Fizz.”
            //If the number is divisible by 5 or contains a 5, print “Buzz.”
            //If the number is divisible by 3 and 5, print “FizzBuzz.”
            //Otherwise, print the number.
            string outPath = "FizzBuzz.txt";
            int countTo = 300;
            
            using (StreamWriter writer = new StreamWriter(outPath, false))
            {
                for (int i = 1; i <= countTo; i++)
                {

                    if (i % 15 == 0)
                    {
                        writer.WriteLine("FizzBuzz ");
                    }
                    else if (i % 5 == 0 || i.ToString().Contains("5"))
                    {
                        writer.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0 || i.ToString().Contains("3"))
                    {
                        writer.WriteLine("Fizz");
                    }
                    else
                    {
                        writer.WriteLine($"{i} ");
                    }


                }

            }





        }
    }
}
