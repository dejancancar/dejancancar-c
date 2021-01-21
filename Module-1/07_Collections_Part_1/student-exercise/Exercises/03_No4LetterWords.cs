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
         Given an array of Strings, return a List containing the same Strings in the same order
         except for any words that contain exactly 4 characters.
         No4LetterWords( {"Train", "Boat", "Car"} )  ->  ["Train", "Car"]
         No4LetterWords( {"Red", "White", "Blue"} )  ->  ["Red", "White"]
         No4LetterWords( {"Jack", "Jill", "Jane", "John", "Jim"} )  ->  ["Jim"]
         */
        public List<string> No4LetterWords(string[] stringArray)
        {
            //convert array to list
            //remove any 4 charachters words 
            //List<string> arrayAsList = new List<string>(stringArray);
            List<string> finalArrayList = new List<string>();

            foreach (string result in stringArray)
                if (result.Length == 4)
                {
                    finalArrayList = finalArrayList;
                }
                else
                    finalArrayList.Add(result);


            //arrayAsList.Join
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    if (stringArray[i])
            //    {
            //        arrayAsList.RemoveAt(i);
            //    }
            //    if (stringArray.Substring(0, 4))
            //    {
            //        arrayAsList.Remove();
            //    }
            //}

            return finalArrayList;
        }
    }
}
