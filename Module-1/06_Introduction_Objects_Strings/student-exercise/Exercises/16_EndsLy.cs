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
         Given a string, return true if it ends in "ly".
         EndsLy("oddly") → true
         EndsLy("y") → false
         EndsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {

            //string ifLy = str.Substring(str.Length - 2);
            int tooShort = str.Length;

            if(tooShort >= 2)
            {
                string ifLy = str.Substring(str.Length - 2);
                if (ifLy == "ly")
                {
                    return true;
                }
                return false;
            }
            
            return false;
        }
    }
}
