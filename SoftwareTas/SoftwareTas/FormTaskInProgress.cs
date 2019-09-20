using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas
{
    public partial class FormTaskInProgress : Form
    {
        Timer timer = new Timer();
        public FormTaskInProgress()
        {
            InitializeComponent();
            timer.Interval = 500;
            prgrssBar.Value = 0;
            prgrssBar.Maximum = 100;
            timer.Tick += timerTick;
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            if(prgrssBar.Value< prgrssBar.Maximum)
            prgrssBar.Value++;
            else
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
