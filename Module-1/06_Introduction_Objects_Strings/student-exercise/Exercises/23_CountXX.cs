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
         Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".
         CountXX("abcxx") → 1
         CountXX("xxx") → 2
         CountXX("xxxx") →
         */
        public int CountXX(string str)
        {
            //int countOfXx = 0;
            //if(str.Equals("xx"))
            //{
            //    countOfXx++;
            //}
            //return countOfXx;
            int lengthOfStr = str.Length;
            int addUpTheXxs = 0;            
            for (int i = 0; i < lengthOfStr - 1; i++)
            {
                if (str.Substring(i,2).Equals("xx")) //if in str the loop finds x and x+1 is also x
                {
                    addUpTheXxs++;

                }
                
            }
            return addUpTheXxs;

        }
    }
}
