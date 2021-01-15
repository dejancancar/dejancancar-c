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
        You and your date are trying to get a table at a restaurant. The parameter "you" is the stylishness
        of your clothes, in the range 0..10, and "date" is the stylishness of your date's clothes. The result
        returned will be 0 if you did not get the table, 1 if you might get the table, and 2 if you did get
        the table. If you or your date is very stylish (8 or more), then the result is 2 (yes). With the
        exception that if either of you has style of 2 or less, then the result is 0 (no). Otherwise the
        result is 1 (maybe).
        DateFashion(5, 10) → 2
        DateFashion(5, 2) → 0
        DateFashion(5, 5) → 1
        */
        public int DateFashion(int you, int date)
        {
            // you = stylishness 0 - 10
            // date = stylishness 0 - 10
            // no table is 0, maybe table is 1, and yes table 2.
            // if you or date = 8+ then 2 yes table
            //unless you or date < 2 then no table 0
            // all else is 1 maybe table

            //if you or date is < 2 = 0
            //if you or date is 8+ && you or date is not < 2 = yes
            //else 1
            if(you <= 2  || date <= 2 )
            {
                return 0;
            }
            else if (you >= 8 || date >= 8)
            {
                return 2;
            }

            return 1;
        }

    }
}
