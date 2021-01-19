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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            //find x in string
            //if x is not followed by x false
            //if x is followed by another x = true
            int lengthOfStr = str.Length;
            int xIsAt = str.IndexOf("x");
            if (xIsAt == -1)
            {
                return false;

            }
            else if((xIsAt+1) >= lengthOfStr)
            {
                return false;
            }
            else if(str.Substring(xIsAt,2).Equals("xx"))// || str.Substring(xIsAt,(xIsAt+1)).Equals("x"))
            {
                return true;
            }
            else
            

            return false;
        }
       
       
    }

}
