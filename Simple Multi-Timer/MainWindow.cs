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
            timerManager = new TimerManager();
        }

        public void AddTimer(TimerItem timer)
        {
            timerManager.Add(timer);
            TimerItemView timerItemViev = new TimerItemView(timer);
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
    }
}
