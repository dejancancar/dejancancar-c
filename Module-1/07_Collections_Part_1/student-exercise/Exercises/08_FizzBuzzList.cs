using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of Integers, return a List that contains the same Integers (as Strings). Except any multiple of 3
        should be replaced by the String "Fizz", any multiple of 5 should be replaced by the String "Buzz",
        and any multiple of both 3 and 5 should be replaced by the String "FizzBuzz"
        ** INTERVIEW QUESTION **

        FizzBuzzList( {1, 2, 3} )  ->  ["1", "2", "Fizz"]
        FizzBuzzList( {4, 5, 6} )  ->  ["4", "Buzz", "6"]
        FizzBuzzList( {7, 8, 9, 10, 11, 12, 13, 14, 15} )  ->  ["7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]

        HINT: To convert an integer x to a string you can call x.ToString() in your code (e.g. if x = 1 then x.ToString() equals "1")
        */
        public List<string> FizzBuzzList(int[] integerArray)
        {
            List<string> emptyList = new List<string>();
            //empty list 

            //make a for each loop to check each element
            foreach (int result in integerArray)
            {
                //if result is divisible by 3 and 5
                if (result % 5 == 0 && result % 3 == 0)
                {
                    emptyList.Add("FizzBuzz");

                }
                else if (result % 5 == 0)
                {
                    emptyList.Add("Buzz");
                }
                else if (result % 3 == 0)
                {
                    emptyList.Add("Fizz");
                }
                else
                    emptyList.Add(result.ToString());

            }



            //array of int, convert to list as strings but with same ints
            //if multiple of 3 replace with fizz
            //if muttiple of 5 replace with buzz
            //if multiple of 3 and 5 replace with fizzbuzz
            return emptyList;
        }
    }
}
