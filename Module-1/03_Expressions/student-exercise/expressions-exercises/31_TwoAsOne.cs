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
         Given three ints, a b c, return true if it is possible to add two of the ints to get the third.
         TwoAsOne(1, 2, 3) → true
         TwoAsOne(3, 1, 2) → true
         TwoAsOne(3, 2, 2) → false
         */
        public bool TwoAsOne(int a, int b, int c)
        {
            //if a & b = c true
            //if a & c = b true
            //if b & c = a true
            if(a + b == c || a + c == b || b + c == a)
            {
                return true;
            }
            return false;
        }

    }
}
