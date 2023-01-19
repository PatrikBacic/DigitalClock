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
            DateTime pt = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"));
            DateTime et = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
            DateTime gmt = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"));
            DateTime jst = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"));

            timeLabel.Text = DateTime.Now.ToString();

            switch (timezoneListBox.SelectedIndex)
            {
                case 0:
                    displayTzLabel.Text = "Central European Time";
                    timeLabel.Text = DateTime.Now.ToString();
                    break;
                case 1:
                    displayTzLabel.Text = "Pacific Time(USA, West Coast)";
                    timeLabel.Text = pt.ToString();
                    break;
                case 2:
                    displayTzLabel.Text = "Eastern time(USA, East Coast)";
                    timeLabel.Text = et.ToString();
                    break;
                case 3:
                    displayTzLabel.Text = "Greenwich Mean Time(UK)";
                    timeLabel.Text = gmt.ToString();
                    break;
                case 4:
                    displayTzLabel.Text = "Japan Standard Time";
                    timeLabel.Text = jst.ToString();
                    break;
            }

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
                displayTzLabel.ForeColor = Color.Black;
                bright = true;
            }
            else
            {
                bmButton.Text = "Bright mode";
                bmButton.ForeColor = Color.Black;
                bmButton.BackColor = Color.White;
                this.BackColor = Color.Black;
                timeLabel.ForeColor = Color.Green;
                displayTzLabel.ForeColor = Color.Green;
                bright = false;
            }
        }

        private void timezoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

    }
}
