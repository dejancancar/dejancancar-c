using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models
{
    public class HotelReservation
    {
        private decimal estTotal = 0;
        private decimal actualTotal = 0;
        //cost per night stayed
        private decimal costPerNight = 59.99M;
        private decimal costForMiniBar = 12.99M;
        private decimal costForCleaning = 34.99m;
        bool requiresCleaning;
        bool usedMiniBar;
        public string Name { get; set; }
        public int NumberOfNights { get; set; }
        public decimal EstimatedTotal
        {
            get
            {
                //total is costPerNight and Number of nights
                //return this.costPerNight * this.NumberOfNights;
                return CostOfOnlyNightsStayed();


            }
        }
        public decimal ActualTotalCost
        {
            get
            {
                if (requiresCleaning)
                {
                    return ActualTotal(true, false);
                }
                if (usedMiniBar)
                {
                    return ActualTotal(false, true);
                }
                if (requiresCleaning && usedMiniBar)
                {
                return ActualTotal(true, true);
                }
                else
                {
                    return this.EstimatedTotal;
                }

            }
        }
        public HotelReservation(string name, int numberOfNights)
        {
            this.Name = name;
            this.NumberOfNights = numberOfNights;

        }
        private decimal CostOfOnlyNightsStayed()
        {
            //TODO add if statement, must be more than 0 nights
            if (this.NumberOfNights > 0)
            {
                estTotal = this.costPerNight * this.NumberOfNights;
            }
            else
            {
                return 0;
            }
            return estTotal;

        }

        private decimal ActualTotal(bool requiresCleaning, bool usedMiniBar)
        {

            //if used mini bar add 12.99

            //if requiresCleaning add 34.99

            //if minibar and cleaning, 34.99 x2
            if (requiresCleaning && usedMiniBar)
            {
                actualTotal = estTotal + (costForMiniBar + (costForCleaning * 2));
            }
            else if (requiresCleaning)
            {
                actualTotal = estTotal + costForCleaning;
            }
            else
            {
                actualTotal = estTotal + costForMiniBar;
            }
            return actualTotal;
        }


    }


}
