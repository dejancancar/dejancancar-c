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
         We are having a party with amounts of tea and candy. Return the int outcome of the party encoded as
         0=bad, 1=good, or 2=great. A party is good (1) if both tea and candy are at least 5. However, if
         either tea or candy is at least double the amount of the other one, the party is great (2). However,
         in all cases, if either tea or candy is less than 5, the party is always bad (0).
         TeaParty(6, 8) → 1
         TeaParty(3, 8) → 0
         TeaParty(20, 6) → 2
         */
        public int TeaParty(int tea, int candy)
        {
            // 0 is bad, 1 is good, 2 is great
            //party = 1 if tea + candy = 5
            // if tea or party is 2x the other = party great
            // if tea or party is < 5 = bad

            if (tea < 5 || candy < 5)
            {
                return 0;
            }
            else if(tea >= (2*candy) || candy >= (2*tea))
            {
                return 2;
            }
            else if (tea >= 5 && candy >= 5)
            {
                return 1;
            }
           
            
            
                
            
            
            return 0;
        }

    }
}
