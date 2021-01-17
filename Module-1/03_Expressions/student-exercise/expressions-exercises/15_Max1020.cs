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
      Given 2 int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {

            //a or b, return bigger value. 
            //if a is in range and bigger return a otherwise
            //if b is in the range and bigger return a
            // a or b is not in 10 - 20 return false
            /* if (b > a) 
             {
                 a = a + b;
                  b = a - b;
                  a = a - b;

             }*/
            if ((a < 10 || a > 20) && (b < 10 || b > 20))
            {
                return 0;
            }
            else if ((a >= 10 && a <= 20) && (b >= 10 && b <= 20) && a > b)
            {
                return a;
            }
            else if ((a >= 10 && a <= 20) && (b >= 10 && b <= 20) && a < b) 
            {
                return b;
            }
             else if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20) && (a > b) && (b > 20))
             {
                return a;
             }
           
            
           
                     return b;
           
            
            
                //return 0;
            
            
            
                
        }

    }
}
