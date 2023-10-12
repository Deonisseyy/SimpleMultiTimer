namespace Simple_Multi_Timer
{
    public class TimerItem
    {
        private string name = "";
        private TimerItemStates state;
        private int seconds;
        private int minutes;
        private int hours;
        private int milliseconds;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public TimerItemStates GetState()
        {
            return state;
        }

        public int getSeconds()
        {
            return seconds;
        }
        public int getMinutes()
        {
            return minutes;
        }
        public int getHours()
        {
            return hours;
        }

        public TimerItem(string name, int hours, int minutes, int seconds)
        {
            this.name = name;
            SetTime(hours, minutes, seconds);
            Reset();
        }

        public void SetTime(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void Start()
        {
            this.state = TimerItemStates.IsRunning;
        }

        public void Stop()
        {
            this.state = TimerItemStates.IsPaused;
        }

        public void Reset()
        {
            this.state = TimerItemStates.IsReady;
            SetMilliseconds();
        }

        public void Update(int milliseconds)
        {
            if (state != TimerItemStates.IsRunning)
            {
                return;
            }
            this.milliseconds -= milliseconds;
            if (this.milliseconds <= 0)
            {
                SetMilliseconds();
                this.state = TimerItemStates.IsReady;
            }
        }

        private void SetMilliseconds()
        {
            this.milliseconds = 0;
            this.milliseconds += seconds;
            this.milliseconds += 60 * minutes;
            this.milliseconds += 60 * 60 * hours;
            this.milliseconds *= 1000;
        }

        public string GetTimeString()
        {
            int mills = this.milliseconds / 1000;
            int currentTimeData = mills % 60;
            string result = currentTimeData.ToString().PadLeft(2, '0');
            mills /= 60;
            currentTimeData = mills % 60;
            result = currentTimeData.ToString().PadLeft(2, '0') + ":" + result;
            currentTimeData = mills /= 60;
            result = currentTimeData.ToString().PadLeft(2, '0') + ":" + result;
            return result;
        }
    }
}
