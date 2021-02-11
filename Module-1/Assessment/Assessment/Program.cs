using Assessment.Models;
using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create instances of your object here and call methods.

            //new object reservations
            HotelReservation reservations = new HotelReservation("Dejan Cancar", 8);
            decimal bleh = reservations.ActualTotal(true, false);




        }
    }
}
