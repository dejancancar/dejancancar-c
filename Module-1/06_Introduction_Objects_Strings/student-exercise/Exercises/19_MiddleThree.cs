using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and".
         The string length will be at least 3.
         MiddleThree("Candy") → "and"
         MiddleThree("and") → "and"
         MiddleThree("solving") → "lvi"
         */
        public string MiddleThree(string str)
        {

            //Odd length
            //3 middle letters
            int lengthOfStr = str.Length;
            int middleLetter = lengthOfStr / 2;
            if (str.Length <= 3)
            {
                return str;
            }
            else 
               return str.Substring(middleLetter-1, 3);
           
            //return null;
        }
    }
}

