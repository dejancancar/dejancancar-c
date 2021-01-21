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
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, int> isItTrue = new Dictionary<string, int>();
            Dictionary<string, bool> trueOrFalse = new Dictionary<string, bool>();
            //check array
            foreach (string word in words)
            {
                if (isItTrue.ContainsKey(word))
                {
                    isItTrue[word] += 1;
                }
                else isItTrue[word] = 1;
            }
            foreach (KeyValuePair<string, int> kvp in isItTrue)
            {
                if (kvp.Value >= 2)
                {
                    trueOrFalse[kvp.Key] = true;
                }
                else
                {
                    trueOrFalse[kvp.Key] = false;
                }
              
            }
            //add array to dictionary

            // if value is more than 1 true or if key is 2 or more true else false


            return trueOrFalse;
        }
    }
}
