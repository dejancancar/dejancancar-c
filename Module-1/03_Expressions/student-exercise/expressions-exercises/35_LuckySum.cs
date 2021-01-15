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
         Given 3 int values, a b c, return their sum. However, if one of the values is 13 then it does not
         count towards the sum and values to its immediate right do not count. So for example, if b is 13, then both
         b and c do not count.
         LuckySum(1, 2, 3) → 6
         LuckySum(1, 2, 13) → 3
         LuckySum(1, 13, 3) → 1
         LuckySum(13, 1, 3) → 3
         LuckySum(13, 13, 3) → 0
         */
        public int LuckySum(int a, int b, int c)
        {
            //dont count 13 and 1 to the right
            //if c = 13 = normal
            // if a =13, only count c
            // if a is not 13 and b is 13 only cont a
            if (a == 13 && b == 13 && c == 13)
            {
                return 0;
            }
            else if (a == 13 && b == 13)
            {
                return 0;
            }
            else if (a == 13 && c == 13)
            {
                return 0;
            }
            else if (a == 13)
            {
                return c;
            }
            else if (b == 13)
            {
                return a;
            }
            else if (c == 13)
            {
                return a + b;
            }
            return a + b + c;
        }
    }
}
