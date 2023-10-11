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

        public TimerItemView(TimerItem timer)
        {
            InitializeComponent();
            this.timer = timer;
            timerNameLabel.Text = timer.GetName();
            timerTimeLabel.Text = timer.GetTimeString();
        }
    }
}
