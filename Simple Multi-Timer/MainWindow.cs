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
    public partial class MainWindow : Form
    {
        private TimerManager timerManager;

        public MainWindow()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
            timerManager = new TimerManager();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.Refresh();
        }

        public void AddTimer(TimerItem timer)
        {
            timerManager.Add(timer);
            TimerItemView timerItemViev = new TimerItemView(timer);
            timerItemViev.SetOwner(this);
            timersContainerPanel.Controls.Add(timerItemViev);
        }

        public void RemoveTimer(TimerItem timer)
        {
            int index = timerManager.Remove(timer);
            timersContainerPanel.Controls.RemoveAt(index);
        }

        private void addTimerButton_Click(object sender, EventArgs e)
        {
            new TimerSettingsForm(this).ShowDialog();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                this.Hide();
            }
        }

        private void trayIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            trayIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
