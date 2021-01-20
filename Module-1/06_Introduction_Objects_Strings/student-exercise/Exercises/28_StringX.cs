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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {

            if (str.Length <= 2)
            {
                return str;
            }

            string first = str.Substring(0, 1);
            string middle = str.Substring(1, str.Length - 2);
            string last = str.Substring(str.Length - 1);

            //Now remove x's from the middle

            middle = middle.Replace("x", "");

            return first + middle + last;
        }
    }
}
