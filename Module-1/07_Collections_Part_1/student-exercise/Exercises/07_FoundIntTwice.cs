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
        Given a List of Integers, and an int value, return true if the int value appears two or more times in
        the list.
        FoundIntTwice( [5, 7, 9, 5, 11], 5 ) -> true
        FoundIntTwice( [6, 8, 10, 11, 13], 8 -> false
        FoundIntTwice( [9, 23, 44, 2, 88, 44], 44) -> true
        */
        public bool FoundIntTwice(List<int> integerList, int intToFind)
        {
            //start with list of intergers
            // take number and see if its in list
            // if number is in list 2 or more times, return true otherwise return false
            //for loop to check every integer
            //if found add one to variable
            int counter = 0;
            foreach (int result in integerList)
            {
                if (intToFind.Equals(result))
                {
                    counter++;
                }
                
                
            }


            if (counter >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
