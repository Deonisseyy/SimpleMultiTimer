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

        public TimerSettingsForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }

        public TimerSettingsForm(TimerItem timer)
        {
            InitializeComponent();
            errorLabel.Text = "";
            this.timer = timer;
            timerNameLabel.Text = timer.GetName();
            hoursUpDown.Value = timer.getHours();
            minutesUpDown.Value = timer.getMinutes();
            hoursUpDown.Value = timer.getSeconds();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
