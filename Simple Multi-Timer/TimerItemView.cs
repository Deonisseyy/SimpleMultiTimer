using System.Windows.Forms;

namespace Simple_Multi_Timer
{
    public partial class TimerItemView : UserControl
    {
        private TimerItem timer;
        private MainWindow owner;
        private Color activeColor = Color.White;
        private Color inactiveColor = Color.FromArgb(127, 127, 127);

        public TimerItemView(TimerItem timer)
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PauseResumeButton, "Pause/resume timer");
            toolTip.SetToolTip(ResetButton, "Reset timer");
            toolTip.SetToolTip(EditButton, "Edit timer");
            toolTip.SetToolTip(DeleteButton, "Delete timer");
            this.timer = timer;
            timerNameLabel.Text = timer.GetName();
            timerTimeLabel.Text = timer.GetTimeString();
            timer.TimerElapsed += NotifyUser;
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
            switch (timer.GetState())
            {
                case TimerItemStates.IsRunning:
                    PauseResumeButton.Image = Properties.Resources.pause;
                    timerTimeLabel.ForeColor = activeColor;
                    break;
                case TimerItemStates.IsReady:
                    PauseResumeButton.Image = Properties.Resources.play;
                    timerTimeLabel.ForeColor = inactiveColor;
                    break;
                case TimerItemStates.IsPaused:
                    PauseResumeButton.Image = Properties.Resources.play;
                    timerTimeLabel.ForeColor = activeColor;
                    break;
                case TimerItemStates.IsFinished:
                    PauseResumeButton.Image = Properties.Resources.play;
                    timerTimeLabel.ForeColor = inactiveColor;
                    break;
            }
        }

        private void NotifyUser(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "Simple Multi Timer";
            notifyIcon.BalloonTipText = "Timer " + timer.GetName() + " has finished.";
            notifyIcon.ShowBalloonTip(5000);
            notifyIcon.Visible = false;
        }
    }
}
