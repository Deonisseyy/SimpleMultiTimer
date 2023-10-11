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
        public TimerSettingsForm()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
