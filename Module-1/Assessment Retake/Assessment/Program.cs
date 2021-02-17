using System;
using System.Collections.Generic;
using System.IO;

using Assessment.Models;

namespace Assessment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Path path = new Path();
            // TODO: Create instances of your object here and call methods.
            Car myCar = new Car(2017, "Kia", false);

            //test method
            //bool needsEcheck = myCar.NeedsEcheck(2016, false);

            bool needsEcheck = myCar.NeedsEcheck(myCar.Year, false);

            //test to string
            Console.WriteLine($"{myCar} Does it need a ECheck? : {needsEcheck}");
        }

    }
}
