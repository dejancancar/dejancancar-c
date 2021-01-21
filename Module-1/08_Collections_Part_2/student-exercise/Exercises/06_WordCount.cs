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
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            //dictionary string in 
            Dictionary<string, int> result = new Dictionary<string, int>();
            
            //bool exists = result.ContainsKey()
           //int valueCounter = 1;

            //loop through array
            foreach (string word in words)
            {
                if (result.ContainsKey(word))
                {
                    //valueCounter += 1;
                    result[word] += 1;
                }
                else
                {
                    result[word] = 1;
                }
            }

            //check word, add to dictionary if not there, plus one if there (contains key ) key.value+1


            //multiple of the same word is one key but number of times that word appears goes up

            return result;
        }
    }
}
