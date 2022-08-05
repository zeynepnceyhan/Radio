namespace methods
{
    public class Radio
    {
        public int channel = 1;
        public int volumeLevel = 1;
        public Boolean on;

        public Radio()
        {

        }

        public void turnOn()
        {
            on = true;
        }

        public void turnOff()
        {
            on = false;
        }

        public void setChannel(int newChannel)
        {
            if (on && newChannel >= 1 && newChannel <= 120)
            {
                channel = newChannel;
            }
        }

        public void setVolume(int newVolumeLevel)
        {
            if (on && newVolumeLevel >= 1 && newVolumeLevel <= 7)
            {
                volumeLevel = newVolumeLevel;
            }
        }
        public void channelUp()
        {
            if (on && channel < 120)
            {
                channel++;
            }
        }
        public void channelDown()
        {
            if (on && channel > 1)
            {
                channel--;
            }
        }
        public void volumeUp()
        {
            if (on && volumeLevel < 7)
            {
                volumeLevel++;
            }
        }
        public void volumeDown()
        {
            if (on && volumeLevel > 1)
            {
                volumeLevel--;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio1 = new Radio();
            radio1.turnOn();
            radio1.setChannel(30);
            radio1.setVolume(3);

            Radio radio2 = new Radio();
            radio2.turnOn();
            radio2.channelUp();
            radio2.channelUp();
            radio2.volumeUp();

            Console.WriteLine("Radio1's channel is " + radio1.channel + " and volume level is " + radio1.volumeLevel);
            Console.WriteLine("Radio2" +
                "'s channel is " + radio2.channel + " and volume level is " + radio2.volumeLevel);

        }


    }
}