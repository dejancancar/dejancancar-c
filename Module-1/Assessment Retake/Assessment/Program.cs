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
            List<Car> carlist = new List<Car>();
            int totalAge = 0;
            string path = @"..\..\..\Data\CarInput.csv";
            using (StreamReader rdr = new StreamReader(path))
            {
                while(!rdr.EndOfStream) 
                {
                    string pathinput = rdr.ReadLine();
                    string[] car = pathinput.Split(",");
                    int year = int.Parse(car[0]);
                    string make = car[1];
                    bool isClassic = bool.Parse(car[2]);
                    Car newcar = new Car(year, make, isClassic);
                    carlist.Add(newcar);
                    totalAge += newcar.Age;
                    
                }
            }
            Console.WriteLine($"The total age of the cars is {totalAge}");
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
