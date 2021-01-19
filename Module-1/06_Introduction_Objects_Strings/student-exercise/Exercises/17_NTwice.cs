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
         Given a string and an int n, return a string made of the first and last n chars from the string. The
         string length will be at least n.
         NTwice("Hello", 2) → "Helo"
         NTwice("Chocolate", 3) → "Choate"
         NTwice("Chocolate", 1) → "Ce"
         */
        public string NTwice(string str, int n)
        {
            //look at size of N
            //take n and number of letters from front and back and add them together

            // str.substring(0,n) str.substring-n

            return str.Substring(0,n)+str.Substring(str.Length-n);
        }
    }
}
