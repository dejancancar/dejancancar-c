namespace Individual.Exercises.Classes
{
    public class Airplane
    {


        public string PlaneNumber { get; private set; }

        public int TotalFirstClassSeats { get; private set; }

        public int BookedFirstClassSeats { get; private set; }

        public int AvailableFirstClassSeats
        {
            get
            {
                int firstClassSeats = this.TotalFirstClassSeats - this.BookedFirstClassSeats;
                return firstClassSeats;
            }
        }

        public int TotalCoachSeats { get; private set; }

        public int BookedCoachSeats { get; private set; }

        public int AvailableCoachSeats
        {
            get
            {
                int coachSeats = this.TotalCoachSeats - this.BookedCoachSeats;
                return coachSeats;

            }
        }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool firstSeatsAvail = totalNumberOfSeats <= this.AvailableFirstClassSeats;
            bool coachClassAvail = !forFirstClass && (totalNumberOfSeats <= this.AvailableCoachSeats);
            if (firstSeatsAvail)
            {
                this.BookedFirstClassSeats += totalNumberOfSeats;
                return true;

            }
            else if (coachClassAvail)
            {

                this.BookedCoachSeats += totalNumberOfSeats;
                return true;
            }
            else
            {
                return false;
            }
            

        }

    }
}
