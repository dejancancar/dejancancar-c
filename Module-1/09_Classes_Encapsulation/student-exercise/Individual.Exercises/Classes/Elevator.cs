namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; }

        public int NumberOfLevels { get; private set; }

        public bool DoorIsOpen { get; private set; }
        public Elevator(int numberOfLevels)
        {

            this.NumberOfLevels = numberOfLevels;
            this.CurrentLevel = 1;

        }

        public void OpenDoor()
        {
            if (this.DoorIsOpen == false)
            {
                this.DoorIsOpen = true;
            }
            //else
            //    this.DoorIsOpen = false;

        }

        public void CloseDoor()
        {
            if (this.DoorIsOpen == true)
            {
                this.DoorIsOpen = false;
            }
            //else
            //    this.DoorIsOpen = true;

        }
        public void GoUp(int desiredFloor)
        {
            if (this.DoorIsOpen == false)
            {
                if (desiredFloor > this.NumberOfLevels)
                {
                    this.CurrentLevel = this.NumberOfLevels;
                }
                else if (desiredFloor <= this.NumberOfLevels && this.CurrentLevel < desiredFloor)
                {
                    this.CurrentLevel++;
                }
                
                

            }
        }
        public void GoDown(int desiredFloor)
        {
            if (this.DoorIsOpen == false)
            {
               
                if (desiredFloor > 0 && this.CurrentLevel > desiredFloor)
                {
                    this.CurrentLevel--;
                }
                
            }
        }

    }

}
