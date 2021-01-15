﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return the number of even ints in the given array. Note: the % "mod" operator computes the
         remainder, e.g. 5 % 2 is 1.
         CountEvens([2, 1, 2, 3, 4]) → 3
         CountEvens([2, 2, 0]) → 3
         CountEvens([1, 3, 5]) → 0
         */
        public int CountEvens(int[] nums)
        {
            //Look at array, get every even number and return total of even numbers
            //first loop through even numbers in array
            //add everytime loop counts even number
            int addOneForEvens = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] % 2 == 0) // make sure to check the INDEX of array for even not i
                {
                    addOneForEvens += 1;
                }
                
            }
            return addOneForEvens;


        }

    }
}
