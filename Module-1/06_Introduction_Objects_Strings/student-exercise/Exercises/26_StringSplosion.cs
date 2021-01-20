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
         Given a non-empty string like "Code" return a string like "CCoCodCode".
         StringSplosion("Code") → "CCoCodCode"
         StringSplosion("abc") → "aababc"
         StringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {
            //save string, add string - 1, continue until string is index 1
            //print string-1 + string
            //print string-2 + string
            //loop until string is equal to 1
            string result = "";
            int lengthOfStr = str.Length;
            for (int i = 0; i < str.Length + 1; i++)
            {
                result = result + str.Substring(0, i);
            }


            return result;
        }
    }
}
