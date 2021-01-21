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
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         *
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         *
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         *
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {
            //if peter has more money than 0, and paul has less than 10, transfer half
            //look at key for peter and check value
            //look at key for paul and check value
            //if paul has less than 10, transfer half from peter
            //otherwise leave it alone
            bool ifPaul = peterPaul.ContainsKey("Paul");
            int paulMoney = peterPaul["Paul"];
            int peterMoney = peterPaul["Peter"];
            //Dictionary<string, int> result = new Dictionary<string, int>();

            if (ifPaul)
            {
                if (paulMoney < 1000)
                {
                    paulMoney = paulMoney + peterMoney / 2;
                    peterMoney = peterMoney / 2;
                    peterPaul["Peter"] = peterMoney;
                    peterPaul["Paul"] = paulMoney;
                }
           
            } 
            
            return peterPaul;
        }
        
       
    }
}