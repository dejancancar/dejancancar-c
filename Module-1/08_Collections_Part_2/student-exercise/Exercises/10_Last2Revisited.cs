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
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         *
         */
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            //check first two and check last two, if they equal add one to value

            //don't count last index but any doubles in the word counts as plus 1. (see xxxx=2 example)

            //create dictionary string, int

            //foreach loop, check last 2 (substring), see if equal first two
            // if equal first 2, add one, else 0.

            //word contains the above 2 letters of the substring, 

            //string hello = "hellohellohello";
            //string lasttwo = hello.Substring(hello.Length- 2);

            //for (int i = 0; i < hello.Length-1; i++)
            //{ if(hello.Substring(i,2) == lasttwo)
            //    count ++;
            //}
            Dictionary<string, int> final = new Dictionary<string, int>();

            foreach (string word in words)
            {
                int count = 0;
                string lastTwo = word.Substring(word.Length - 2);
                for (int i = 0; i < word.Length - 2; i++)
                {
                    if (word.Substring(i, 2).Equals(lastTwo))
                    {
                        count++;
                    }


                }
                final[word] = count;






            }






            return final;
        }
    }
}
