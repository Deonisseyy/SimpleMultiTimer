using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Multi_Timer
{
    public partial class TimerItemView : UserControl
    {
        private TimerItem timer;
        private MainWindow owner;

        public TimerItemView(TimerItem timer)
        {
            InitializeComponent();
            this.timer = timer;
            timerNameLabel.Text = timer.GetName();
            timerTimeLabel.Text = timer.GetTimeString();
        }

        public void SetOwner(MainWindow owner)
        {
            this.owner = owner;
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            switch (timer.GetState())
            {
                case TimerItemStates.IsRunning:
                    timer.Stop();
                    break;
                case TimerItemStates.IsReady:
                    timer.Start();
                    break;
                case TimerItemStates.IsPaused:
                    timer.Start();
                    break;
                case TimerItemStates.IsFinished:
                    timer.Reset();
                    timer.Start();
                    break;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            timer.Reset();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new TimerSettingsForm(timer).ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            owner.RemoveTimer(timer);
        }

        private void TimerItemView_Paint(object sender, PaintEventArgs e)
        {
            timerNameLabel.Text = timer.GetName();
            timerTimeLabel.Text = timer.GetTimeString();
        }
    }
}
