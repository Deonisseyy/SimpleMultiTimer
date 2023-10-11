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
            errorLabel.Text = "";
        }

        public TimerSettingsForm(TimerItem timer)
        {
            InitializeComponent();
            errorLabel.Text = "";
            this.timer = timer;
            timerNameTextBox.Text = timer.GetName();
            hoursUpDown.Value = Convert.ToDecimal(timer.getHours());
            minutesUpDown.Value = Convert.ToDecimal(timer.getMinutes());
            secondsUpDown.Value = Convert.ToDecimal(timer.getSeconds());
        }

        public TimerSettingsForm(MainWindow window)
        {
            InitializeComponent();
            errorLabel.Text = "";
            this.window = window;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                string name = timerNameTextBox.Text;
                timer.SetName(name);
                int seconds = Convert.ToInt32(secondsUpDown.Value);
                int minutes = Convert.ToInt32(minutesUpDown.Value);
                int hours = Convert.ToInt32(hoursUpDown.Value);
                timer.SetTime(hours, minutes, seconds);
                timer.Reset();
            }
            else
            {
                string name = timerNameTextBox.Text;
                int seconds = Convert.ToInt32(secondsUpDown.Value);
                int minutes = Convert.ToInt32(minutesUpDown.Value);
                int hours = Convert.ToInt32(hoursUpDown.Value);
                window.AddTimer(new TimerItem(name, hours, minutes, seconds));
            }
            Close();
        }
    }
}
