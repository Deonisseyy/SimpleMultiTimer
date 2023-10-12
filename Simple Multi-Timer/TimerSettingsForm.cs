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
    public partial class TimerSettingsForm : Form
    {
        private TimerItem timer;
        private MainWindow window;
        private TimerSettingsForm()
        {
            InitializeComponent();
            errorLabel.Text = "Time must be greater than 0.";
        }

        public TimerSettingsForm(TimerItem timer)
        {
            InitializeComponent();
            errorLabel.Text = "Time must be greater than 0.";
            this.timer = timer;
            timerNameTextBox.Text = timer.GetName();
            hoursUpDown.Value = Convert.ToDecimal(timer.getHours());
            minutesUpDown.Value = Convert.ToDecimal(timer.getMinutes());
            secondsUpDown.Value = Convert.ToDecimal(timer.getSeconds());
        }

        public TimerSettingsForm(MainWindow window)
        {
            InitializeComponent();
            errorLabel.Text = "Time must be greater than 0.";
            this.window = window;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(secondsUpDown.Value);
            int minutes = Convert.ToInt32(minutesUpDown.Value);
            int hours = Convert.ToInt32(hoursUpDown.Value);
            if (seconds == 0 && minutes == 0 && hours == 0)
            {
                return;
            }
            if (timer != null)
            {
                timer.Stop();
                string name = timerNameTextBox.Text;
                timer.SetName(name);
                timer.SetTime(hours, minutes, seconds);
                timer.Reset();
            }
            else
            {
                string name = timerNameTextBox.Text;
                window.AddTimer(new TimerItem(name, hours, minutes, seconds));
            }
            Close();
        }

        private void VerifyValues(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(secondsUpDown.Value);
            int minutes = Convert.ToInt32(minutesUpDown.Value);
            int hours = Convert.ToInt32(hoursUpDown.Value);
            if (seconds == 0 && minutes == 0 && hours == 0)
            {
                errorLabel.Text = "Time must be greater than 0.";
            }
            else
            {
                errorLabel.Text = "";
            }
            errorLabel.Refresh();
        }
    }
}