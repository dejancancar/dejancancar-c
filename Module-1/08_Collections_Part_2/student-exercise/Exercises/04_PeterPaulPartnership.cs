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
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         *
         * PeterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * PeterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         *
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            //modify and return peterPaul
            //if Peter has 5000 or more AND paul has 10000 or more
            //then PeterPaulP is .25 times peter and paul added together

            //string for peter money 
            double peterMoney = peterPaul["Peter"];
            //String for paul money
            //Dictionary<string, int> result = new Dictionary<string, int>();
            double paulMoney = peterPaul["Paul"];
            double moneyBoth = 0;
            if (peterMoney >= 50000 && paulMoney >= 10000)
            {
                moneyBoth = (paulMoney * .25) + (peterMoney * .25);
                peterMoney = peterMoney * .75;
                paulMoney = paulMoney * .75;
                peterPaul["Peter"] = (int)peterMoney;
                peterPaul["Paul"] = (int)paulMoney;
                peterPaul["PeterPaulPartnership"] = (int)moneyBoth;
            }



            return peterPaul;
        }
    }
}
