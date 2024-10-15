using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        int pomodoroMinutes = 25;
        int pomodoroSeconds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Stop();
            pomodoroMinutes = 25;
            pomodoroSeconds = 0;
            lblTimer.Text = "25:00";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void pomodoroTimer_Tick(object sender, EventArgs e)
        {
            if (pomodoroSeconds == 0)
            {
                if (pomodoroMinutes == 0)
                {
                    pomodoroTimer.Stop();
                    lblTimer.Text = "Time's up!";
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    return;
                }
                pomodoroMinutes--;
                pomodoroSeconds = 59;
            }
            else
            {
                pomodoroSeconds--;
            }

            lblTimer.Text = $"{pomodoroMinutes:D2}:{pomodoroSeconds:D2}";
        }

    }
}
