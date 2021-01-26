namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; } = 1;

        public int NumberOfLevels { get; private set; }

        public bool DoorIsOpen { get; private set; }
        public Elevator(int numberOfLevels)
        {

            this.NumberOfLevels = numberOfLevels;
            //this.CurrentLevel = 1;

        }

        public void OpenDoor()
        {
            //if (this.DoorIsOpen == false)
            //{
            //    this.DoorIsOpen = true;
            //}
              this.DoorIsOpen = true;

        }

        public void CloseDoor()
        {
            //if (this.DoorIsOpen == true)
            //{
            //    this.DoorIsOpen = false;
            //}
            ////else
              this.DoorIsOpen = false;

        }
        public void GoUp(int desiredFloor)
        {
            //if (this.DoorIsOpen == false)
            //{
                //if (desiredFloor > this.NumberOfLevels)
                //{
                //    this.CurrentLevel = this.NumberOfLevels;
                //}
                //else if (desiredFloor <= this.NumberOfLevels && this.CurrentLevel < desiredFloor)
                //{
                //    this.CurrentLevel++;
                //}
                
                if (this.DoorIsOpen || desiredFloor <= this.CurrentLevel || desiredFloor > this.NumberOfLevels)
                {
                    return;
                }
                this.CurrentLevel = desiredFloor;
                

            //}
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
