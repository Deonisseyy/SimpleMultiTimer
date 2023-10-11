using System.Timers;

namespace Simple_Multi_Timer
{
    internal class TimerManager
    {
        private List<TimerItem> timers = new List<TimerItem>();
        private int updateInterval = 500;
        private System.Timers.Timer timerUpdater;

        public TimerManager()
        {
            timerUpdater = new System.Timers.Timer(updateInterval);
            timerUpdater.Elapsed += UpdateAll;
            timerUpdater.AutoReset = true;
            timerUpdater.Enabled = true;
        }

        public void UpdateAll(object source, ElapsedEventArgs e)
        {
            foreach (TimerItem timer in timers)
            {
                timer.Update(updateInterval);
            }
        }

        public void Start()
        {
            foreach (TimerItem timer in timers)
            {
                timer.Start();
            }
            timerUpdater.Start();
        }

        public void Stop()
        {
            foreach(TimerItem timer in timers)
            {
                timer.Stop();
            }
            timerUpdater.Stop();
        }

        public void Add(TimerItem item)
        {
            timers.Add(item);
        }

        public void Remove(int index)
        {
            timers.RemoveAt(index);
        }
    }
}
