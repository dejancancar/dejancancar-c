namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; } = false;

        public int CurrentChannel { get; private set; } = 3;

        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            this.IsOn = false;
        }
        public void TurnOn()
        {
            this.IsOn = true;
            this.CurrentVolume = 2;
            this.CurrentChannel = 3;
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn)
            {
                if (this.CurrentChannel <= 18 & this.CurrentChannel >= 3)
                {
                    this.CurrentChannel = newChannel;
                }
            }

        }
        public void ChannelUp()
        {
            if (IsOn)
            {
                if (this.CurrentChannel == 18)
                {
                    this.CurrentChannel = 3;
                }
                else if (this.CurrentChannel < 18)
                {
                    this.CurrentChannel++;
                }

            }

        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                if (this.CurrentChannel == 3)
                {
                    this.CurrentChannel = 18;
                }
                else if (this.CurrentChannel <= 17)
                {
                    this.CurrentChannel--;
                }
            }

        }
        public void RaiseVolume()
        {
            if(IsOn && this.CurrentVolume < 10)
            {
                this.CurrentVolume++;
            }

        }

        public void LowerVolume()
        {
            if(IsOn && this.CurrentVolume > 0)
            {
                this.CurrentVolume--;
            }

        }



    }

}

