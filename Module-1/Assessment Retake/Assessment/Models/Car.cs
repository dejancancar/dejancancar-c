using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public bool IsClassicCar { get; set; }
        public int Age
        {
            get
            {
                int yearsOld;
                int currentYear = DateTime.Now.Year;
                return yearsOld = currentYear - this.Year;
            }

        }

        public Car(int year, string make, bool isClassicCar)
        {
            this.Year = year;
            this.Make = make;
            this.IsClassicCar = isClassicCar;
        }

        public bool NeedsEcheck(int yearToCheck, bool isClassicCar)
        {
            if (yearToCheck <= 0)
            {
                Console.WriteLine($"{yearToCheck} is an invalid year");
                return false;
            }
            int yearsOld = DateTime.Now.Year - yearToCheck;
            if (yearsOld < 4 || yearsOld > 25 || isClassicCar)
            {
                return false;
            }
            else
            {
                if (yearToCheck % 2 == 0 && DateTime.Now.Year % 2 == 0)
                {
                    return true;
                }
                else if (yearToCheck % 2 == 1 && DateTime.Now.Year % 2 == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public override string ToString()
        {
            return $"CAR - {this.Year} - {this.Make}";
        }

    }
}
