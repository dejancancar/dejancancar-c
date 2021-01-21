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
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
            Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> bothWarehouses = new Dictionary<string, int>();
            //add list 1 to the string

            //loop through and check for matching key, if match key add values, if not add it to the list 

            // adding with bracket?
          
            foreach (KeyValuePair<string,int> kvp in mainWarehouse)
            {
                bothWarehouses[kvp.Key] = kvp.Value;

            }
         
            foreach (KeyValuePair<string, int> kvp in remoteWarehouse)
            {
                if (bothWarehouses.ContainsKey(kvp.Key))
                {
                    bothWarehouses[kvp.Key] += kvp.Value;
                }
                else
                {
                    bothWarehouses[kvp.Key] = kvp.Value;
                }
              
            }



            return bothWarehouses;
        }
    }
}
