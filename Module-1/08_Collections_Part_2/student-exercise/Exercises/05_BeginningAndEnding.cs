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
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            //make dictionary string string
            Dictionary<string, string> result = new Dictionary<string, string>();
            string firstLetter = "";
            string lastLetter = "";
            
            //for loop to go through array
            foreach (string word in words)
            {
                firstLetter = word.Substring(0, 1);
                lastLetter = word.Substring(word.Length - 1);
                result[firstLetter] = lastLetter;

            }
            //index string array and add to dictionary array

            return result;
        }
    }
}
