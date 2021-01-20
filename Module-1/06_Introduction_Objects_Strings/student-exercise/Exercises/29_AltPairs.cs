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
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         AltPairs("kitten") → "kien"
         AltPairs("Chocolate") → "Chole"
         AltPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            string result = "";

            for (int i = 0; i <= str.Length; i += 4)
            {
                
                if (str.Length < i+2)
                {
                    result += str.Substring(i);
                }
                else
                    result += str.Substring(i, 2);
                
                //take out element 3 and 4 , 6 and 7 etc
                //loop goes up by 2
                // must be shorter than length of str
                //First 2 elements in the index

            }
            return result;
        }
    }
}
