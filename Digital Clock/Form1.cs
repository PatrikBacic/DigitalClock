using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class DigitalClock : Form
    {

        bool bright = false;
        public DigitalClock()
        {
            InitializeComponent();
            bmButton.FlatStyle = FlatStyle.Flat;
        }
        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("G");
        }

        private void bmButton_Click(object sender, EventArgs e)
        {

            if(bright == false)
            {
                bmButton.Text = "Dark mode";
                bmButton.ForeColor = Color.White;
                bmButton.BackColor = Color.Black;
                this.BackColor = Color.White;
                timeLabel.ForeColor = Color.Black;
                bright = true;
            }
            else
            {
                bmButton.Text = "Bright mode";
                bmButton.ForeColor = Color.Black;
                bmButton.BackColor = Color.White;
                this.BackColor = Color.Black;
                timeLabel.ForeColor = Color.Green;
                bright = false;
            }
        }

    }
}
